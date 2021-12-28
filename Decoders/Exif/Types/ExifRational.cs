﻿// -----------------------------------------------------------------------
// <copyright file="ExifRational.cs" company="CodeRanger.com">
//     CodeRanger.com. All rights reserved
// </copyright>
// <author>Dan Petitt</author>
// <comment></comment>
// -----------------------------------------------------------------------

namespace Coderanger.ImageInfo.Decoders.Exif.Types;

using Coderanger.ImageInfo.Decoders.DecoderUtils;

/// <summary>
/// 
/// </summary>
public class ExifRational: ExifTypeValue, IExifValue
{
  internal ExifRational( BinaryReader reader, ExifComponent component )
    : base( ExifType.Rational, reader, component )
  {
  }

  public string StringValue => ToString();

  void IExifValue.SetValue()
  {
    ProcessData();
  }

  internal override IEnumerable<ExifTagValue> ExtractValues()
  {
    // Rational type is 8 bytes so will always be above the 4 byte buffer so the buffer
    // will contain a reference to the data elsewhere in the IFD, therefore move to
    // that position and read enough bytes for conversion x number of components saved
    var exifValue = DataConversion.Int32FromBuffer( Component.DataValueBuffer, 0, Component.ByteOrder );
    Reader.BaseStream.Seek( Component.DataStart + exifValue, SeekOrigin.Begin );

    for( var i = 0; i < Component.ComponentCount; i++ )
    {
      var dataValue = Reader.ReadBytes( Component.ComponentSize );

      var numerator = DataConversion.Int32FromBuffer( dataValue, 0, Component.ByteOrder );
      var denominator = DataConversion.Int32FromBuffer( dataValue, 4, Component.ByteOrder );

      yield return new ExifTagValue( Type: ExifType, IsArray: IsArray, TagId: Tag, TagName: Name, Value: new Rational( numerator, denominator ) );
    }
  }
}

/// <summary>
/// 
/// </summary>
public class ExifURational : ExifTypeValue, IExifValue
{
  internal ExifURational( BinaryReader reader, ExifComponent component )
    : base( ExifType.URational, reader, component )
  {
  }

  public string StringValue => ToString();

  void IExifValue.SetValue()
  {
    ProcessData();
  }

  internal override IEnumerable<ExifTagValue> ExtractValues()
  {
    // Rational type is 8 bytes so will always be above the 4 byte buffer so the buffer
    // will contain a reference to the data elsewhere in the IFD, therefore move to
    // that position and read enough bytes for conversion x number of components saved
    var exifValue = DataConversion.Int32FromBuffer( Component.DataValueBuffer, 0, Component.ByteOrder );
    Reader.BaseStream.Seek( Component.DataStart + exifValue, SeekOrigin.Begin );

    for( var i = 0; i < Component.ComponentCount; i++ )
    {
      var dataValue = Reader.ReadBytes( Component.ComponentSize );

      var numerator = DataConversion.Int32FromBuffer( dataValue, 0, Component.ByteOrder );
      var denominator = DataConversion.Int32FromBuffer( dataValue, 4, Component.ByteOrder );

      yield return new ExifTagValue( Type: ExifType, IsArray: IsArray, TagId: Tag, TagName: Name, Value: new Rational( numerator, denominator ) );
    }
  }
}
