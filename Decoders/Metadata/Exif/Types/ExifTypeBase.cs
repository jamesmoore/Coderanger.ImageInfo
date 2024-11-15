﻿// -----------------------------------------------------------------------
// <copyright file="ExifTypeValue.cs" company="CodeRanger.com">
//     CodeRanger.com. All rights reserved
// </copyright>
// <author>Dan Petitt</author>
// <comment></comment>
// -----------------------------------------------------------------------

namespace Coderanger.ImageInfo.Decoders.Metadata.Exif.Types;

using Coderanger.ImageInfo.Decoders.DecoderUtils;

/// <summary>
/// Base class describing common properties and methods of an Exif tag value
/// </summary>
public abstract class ExifTypeBase
{
  // Hack: Just used for reflection in the custom description attribute
  internal static readonly ExifTag ReflectionExifTag = new();

  internal ExifTypeBase( MetadataType type, BinaryReader reader, ExifComponent component )
  {
    TagId = component.Tag;
    TagType = type;
    Reader = reader;
    Component = component;

    var tagDetails = MetadataTagDetailsAttribute.GetTagDetails( ReflectionExifTag, TagId );
    if( tagDetails is not null )
    {
      Name = tagDetails.Name;
      Description = tagDetails.Description;
    }
  }

  /// <summary>
  /// Retrieves the objects value type
  /// </summary>
  /// <param name="value">Pass a MetadataTagValue to be set with this objects value</param>
  /// <returns>Returns true if the value has been set</returns>
  public bool TryGetValue( out MetadataTagValue? value )
  {
    ProcessData();
    if( _convertedValue is null )
    {
      value = null;
      return false;
    }

    value = _convertedValue;
    return true;
  }

  /// <summary>
  /// Retrieves the objects value type array
  /// </summary>
  /// <param name="value">Pass a List of MetadataTagValue to be set with this objects array value</param>
  /// <returns>Returns true if the value has been set</returns>
  public bool TryGetValueArray( out List<MetadataTagValue>? value )
  {
    ProcessData();
    if( _convertedValueArray is null || _convertedValueArray.Count == 0 )
    {
      value = null;
      return false;
    }

    value = _convertedValueArray;
    return true;
  }

  /// <summary>
  /// Simple representation of the data for debugging
  /// </summary>
  public string StringValue => ToString();

  /// <summary>
  /// Returns true if the base tag value is an array of values
  /// </summary>
  public virtual bool IsArray => Component.ComponentCount > 1;

  /// <summary>
  /// Returns true if their is a base tag value for this tag
  /// </summary>
  public bool HasValue => _convertedValueArray.Count > 0 || ((string)(_convertedValue?.Value ?? string.Empty)).Length > 0;

  /// <summary>
  /// Returns the base tag's name
  /// </summary>
  public string TagTypeName => TagType.ToString();

  /// <summary>
  /// Returns a string that represents the object
  /// </summary>
  /// <returns>String that represents the object</returns>
  public override string ToString()
  {
    if( IsArray )
    {
      return $"{Name} = {string.Join( " / ", _convertedValueArray )}";
    }
    else
    {
      return $"{Name} = {_convertedValue}";
    }
  }

  internal void ProcessData()
  {
    if( !_processed )
    {
      // Store current reader position for restoring later
      var currentStreamPosition = Reader.Position();

      foreach( var value in ExtractValues() )
      {
        _convertedValueArray.Add( value );
      }

      if( !IsArray && _convertedValueArray.Count > 0 )
      {
        _convertedValue = _convertedValueArray[ 0 ];
      }

      // Reset position
      Reader.Position( currentStreamPosition );

      _processed = true;
    }
  }

  /// <summary>
  /// Override to process the data buffer for each type
  /// </summary>
  /// <returns></returns>
  internal abstract IEnumerable<MetadataTagValue> ExtractValues();

  /// <summary>
  /// Tag identifier
  /// </summary>
  public ushort TagId { get; init; }

  /// <summary>
  /// Exif tag type
  /// </summary>
  public MetadataType TagType { get; init; }

  /// <summary>
  /// Name of tag
  /// </summary>
  public string Name { get; init; } = string.Empty;

  /// <summary>
  /// Description with explanation of tag data
  /// </summary>
  public string Description { get; init; } = string.Empty;

  internal BinaryReader Reader { get; init; }
  internal ExifComponent Component { get; init; }

  internal MetadataTagValue? _convertedValue;
  internal readonly List<MetadataTagValue> _convertedValueArray = new();
  internal const byte BufferByteSize = 4;

  private bool _processed = false;
}
