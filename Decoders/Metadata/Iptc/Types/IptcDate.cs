﻿// -----------------------------------------------------------------------
// <copyright file="IptcDate.cs" company="CodeRanger.com">
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
public class IptcDate : IptcTypeBase, IMetadataTypedValue
{
  internal IptcDate( ushort tagId )
    : base( tagId, MetadataType.Date )
  {
  }

  public void AddToExistingValue( ReadOnlySpan<byte> buffer )
  {
    var value = Create( buffer );
    if( value != null )
    {
      _metadata.Add( value );
    }
  }

  public void SetValue( ReadOnlySpan<byte> buffer )
  {
    var value = Create( buffer );
    if( value != null )
    {
      _metadata.Add( value );
    }
  }

  private MetadataTagValue? Create( ReadOnlySpan<byte> buffer )
  {
    var bufferValue = DataConversion.ConvertBuffer( buffer, StringEncoding.Ascii );
    if( DateOnly.TryParseExact( bufferValue, DateFormatString, null, System.Globalization.DateTimeStyles.None, out var dt ) )
    {
      return new MetadataTagValue( Type: TagType,
                                   IsArray: false,
                                   TagId: TagId,
                                   TagName: Name,
                                   Value: dt );
    }

    return null;
  }

  private const string DateFormatString = "yyyyMMdd";
}