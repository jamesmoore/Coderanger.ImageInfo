﻿// -----------------------------------------------------------------------
// <copyright file="FormatManager.cs" company="CodeRanger.com">
//     CodeRanger.com. All rights reserved
// </copyright>
// <author>Dan Petitt</author>
// <comment>Manages all the decoders</comment>
// -----------------------------------------------------------------------

namespace Coderanger.ImageInfo.Decoders;

using Coderanger.ImageInfo.Decoders.Jpeg;
using Coderanger.ImageInfo.Decoders.Png;

internal class FormatManager
{
  internal IEnumerable<IDecoder> Get()
  {
    foreach( var decoder in _decoders )
    {
      yield return decoder;
    }
  }

  private readonly List<IDecoder> _decoders = new() { 
    new DecodeJpeg(),
    new DecodePng(),
  };
}
