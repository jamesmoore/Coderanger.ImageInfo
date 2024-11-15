﻿// -----------------------------------------------------------------------
// <copyright file="IptcEnum.cs" company="CodeRanger.com">
//     CodeRanger.com. All rights reserved
// </copyright>
// <author>Dan Petitt</author>
// <comment></comment>
// -----------------------------------------------------------------------

namespace Coderanger.ImageInfo.Decoders.Metadata.Iptc.Types;

using System;
using Coderanger.ImageInfo.Decoders.DecoderUtils;

/// <summary>
/// 
/// </summary>
public class IptcEnum : IptcTypeBase, IMetadataTypedValue
{
  internal enum EnumType
  {
    Numeric,
    String,
  }

  internal IptcEnum( ushort tagId, EnumType enumType )
    : base( tagId, MetadataType.Enum )
  {
    _enumType = enumType;
  }

  /// <summary>
  /// Adds a new value to the metadata object
  /// </summary>
  /// <param name="buffer">Buffer which contains the appropriate data value</param>
  public void AddToExistingValue( ReadOnlySpan<byte> buffer )
  {
    var value = Create( buffer );
    if( value is not null )
    {
      _metadata.Add( value );
    }
  }

  /// <summary>
  /// Sets the value of the object
  /// </summary>
  /// <param name="buffer">Buffer which contains the appropriate data value</param>
  public void SetValue( ReadOnlySpan<byte> buffer )
  {
    var value = Create( buffer );
    if( value is not null )
    {
      _metadata.Add( value );
    }
  }

  private MetadataTagValue Create( ReadOnlySpan<byte> buffer )
  {
    var enumValue = GetEnumFromValue( buffer );
    return new MetadataTagValue( Type: TagType,
                                 IsArray: false,
                                 TagId: TagId,
                                 TagName: Name,
                                 Value: enumValue );
  }

  private MetadataEnumValue GetEnumFromValue( ReadOnlySpan<byte> value )
  {
    var bufferValue = DataConversion.ConvertBuffer( value, StringEncoding.Utf8 );

    if( _enumType == EnumType.String )
    {
      var attributeInfo = MetadataTagEnumAttribute.GetTagEnumValue( ReflectionIptcTag, TagId, bufferValue );
      return new MetadataEnumValue( bufferValue, attributeInfo ?? string.Empty );
    }
    else
    {
      var numberValue = Convert.ToUInt16( bufferValue );
      var attributeInfo = MetadataTagEnumAttribute.GetTagEnumValue( ReflectionIptcTag, TagId, numberValue );
      return new MetadataEnumValue( bufferValue, attributeInfo ?? string.Empty );
    }
  }

  private readonly EnumType _enumType;
}
