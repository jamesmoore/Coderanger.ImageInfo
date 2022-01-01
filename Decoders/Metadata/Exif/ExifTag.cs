﻿// -----------------------------------------------------------------------
// <copyright file="ExifTag.cs" company="CodeRanger.com">
//     CodeRanger.com. All rights reserved
// </copyright>
// <author>Dan Petitt</author>
// <comment></comment>
// -----------------------------------------------------------------------

namespace Coderanger.ImageInfo.Decoders.Metadata.Exif;

/// <summary>
/// Tag constants
/// https://www.exiv2.org/tags.html
/// </summary>
public class ExifTag : IMetadataTag
{
  /// <summary>
  /// A pointer to the Exif IFD. Exif IFD has the same structure as that of the IFD specified
  /// in TIFF. ordinarily; however; it does not contain image data as in the case of TIFF
  /// </summary>
  public const ushort ExifIfd = 0x8769;

  /// <summary>
  /// A pointer to the GPS Info IFD. The Interoperability structure of the GPS Info IFD;
  /// like that of Exif IFD; has no image data
  /// </summary>
  public const ushort GPSIfd = 0x8825;

  /// <summary>
  /// Interoperability IFD is composed of tags which stores the information to ensure the
  /// Interoperability and pointed by the following tag located in Exif IFD. The Interoperability
  /// structure of Interoperability IFD is the same as TIFF defined IFD structure but does
  /// not contain the image data characteristically compared with normal TIFF IFD
  /// </summary>
  public const ushort PhotoInteroperabilityTag = 0xa005;

  /// <summary>
  /// Defined by Adobe Corporation to enable TIFF Trees within a TIFF file.
  /// </summary>
  public const ushort SubIFDs = 0x014a;



  /// <summary>
  /// The name and version of the software used to post-process the picture.
  /// </summary>
  public const ushort ProcessingSoftware = 0x000b;

  /// <summary>
  /// A general indication of the kind of data contained in this subfile.
  /// </summary>
  public const ushort NewSubfileType = 0x00fe;

  /// <summary>
  /// A general indication of the kind of data contained in this subfile. This field is deprecated. The NewSubfileType field should be used instead.
  /// </summary>
  public const ushort SubfileType = 0x00ff;

  /// <summary>
  /// The number of columns of image data; equal to the number of pixels per row. In JPEG compressed data a JPEG marker is used instead of this tag.
  /// </summary>
  public const ushort ImageWidth = 0x0100;

  /// <summary>
  /// The number of rows of image data. In JPEG compressed data a JPEG marker is used instead of this tag.
  /// </summary>
  public const ushort ImageHeight = 0x0101;

  /// <summary>
  /// The number of bits per image component. In this standard each component of the image is 8 bits; so the value for this tag is 8. See also <SamplesPerPixel>. In JPEG compressed data a JPEG marker is used instead of this tag.
  /// </summary>
  public const ushort BitsPerSample = 0x0102;

  /// <summary>
  /// The compression scheme used for the image data. When a primary image is JPEG compressed; this designation is not necessary and is omitted. When thumbnails use JPEG compression; this tag value is set to 6.
  /// </summary>
  public const ushort Compression = 0x0103;

  /// <summary>
  /// The pixel composition. In JPEG compressed data a JPEG marker is used instead of this tag.
  /// </summary>
  public const ushort PhotometricInterpretation = 0x0106;

  /// <summary>
  /// For black and white TIFF files that represent shades of gray; the technique used to convert from gray to black and white pixels.
  /// </summary>
  public const ushort Thresholding = 0x0107;

  /// <summary>
  /// The width of the dithering or halftoning matrix used to create a dithered or halftoned bilevel file.
  /// </summary>
  [ExifTagDetails( "Cell Width", "Width of the dithering or halftoning matrix used to create a dithered or halftoned bilevel file" )]
  public const ushort CellWidth = 0x0108;

  /// <summary>
  /// The length of the dithering or halftoning matrix used to create a dithered or halftoned bilevel file.
  /// </summary>
  [ExifTagDetails( "Cell Length", "Length of the dithering or halftoning matrix used to create a dithered or halftoned bilevel file" )]
  public const ushort CellLength = 0x0109;

  /// <summary>
  /// The logical order of bits within a byte
  /// </summary>
  [ExifTagDetails( "Fill Order", "Logical order of bits within a byte" )]
  public const ushort FillOrder = 0x010a;

  /// <summary>
  /// The name of the document from which this image was scanned
  /// </summary>
  [ExifTagDetails( "Document Name", "Name of the document from which this image was scanned" )]
  public const ushort DocumentName = 0x010d;

  /// <summary>
  /// Character string giving the title of the image. It may be a comment such as '1988 company picnic' for example. Two-bytes character codes cannot be used; instead, the Exif tag 'UserComment' is to be used
  /// </summary>
  [ExifTagDetails( "Image Description", "Character string giving the title of the image. It may be a comment such as '1988 company picnic' for example. Two-bytes character codes cannot be used; instead, the Exif tag 'UserComment' is to be used" )]
  public const ushort ImageDescription = 0x010e;

  /// <summary>
  /// The manufacturer of the recording equipment
  /// </summary>
  [ExifTagDetails( "Camera Make", "Manufacturer of the digital still camera (DSC), scanner, video digitizer or other equipment that generated the image. When this is left blank, it is treated as unknown" )]
  public const ushort Make = 0x010f;

  /// <summary>
  /// The model name or model number of the equipment
  /// </summary>
  [ExifTagDetails( "Camera Model", "Model name or number of the digital still camera (DSC), scanner, video digitizer or other equipment that generated the image. When this is left blank, it is treated as unknown" )]
  public const ushort Model = 0x0110;

  /// <summary>
  /// For each strip; the byte offset of that strip. It is recommended that this be selected so the number of strip bytes does not exceed 64 Kbytes. With JPEG compressed data this designation is not needed and is omitted. See also <RowsPerStrip> and <StripByteCounts>.
  /// </summary>
  public const ushort StripOffsets = 0x0111;

  /// <summary>
  /// The image orientation viewed in terms of rows and columns.
  /// </summary>
  public const ushort Orientation = 0x0112;

  /// <summary>
  /// The number of components per pixel. Since this standard applies to RGB and YCbCr images; the value set for this tag is 3. In JPEG compressed data a JPEG marker is used instead of this tag.
  /// </summary>
  public const ushort SamplesPerPixel = 0x0115;

  /// <summary>
  /// The number of rows per strip. This is the number of rows in the image of one strip when an image is divided into strips. With JPEG compressed data this designation is not needed and is omitted. See also <StripOffsets> and <StripByteCounts>.
  /// </summary>
  public const ushort RowsPerStrip = 0x0116;

  /// <summary>
  /// The total number of bytes in each strip. With JPEG compressed data this designation is not needed and is omitted.
  /// </summary>
  public const ushort StripByteCounts = 0x0117;

  /// <summary>
  /// The number of pixels per <ResolutionUnit> in the <ImageWidth> direction. When the image resolution is unknown; 72 [dpi] is designated.
  /// </summary>
  public const ushort XResolution = 0x011a;

  /// <summary>
  /// The number of pixels per <ResolutionUnit> in the <ImageLength> direction. The same value as <XResolution> is designated.
  /// </summary>
  public const ushort YResolution = 0x011b;

  /// <summary>
  /// Indicates whether pixel components are recorded in a chunky or planar format. In JPEG compressed files a JPEG marker is used instead of this tag. If this field does not exist; the TIFF default of 1 (chunky) is assumed.
  /// </summary>
  public const ushort PlanarConfiguration = 0x011c;

  /// <summary>
  /// The precision of the information contained in the GrayResponseCurve.
  /// </summary>
  public const ushort GrayResponseUnit = 0x0122;

  /// <summary>
  /// For grayscale data; the optical density of each possible pixel value.
  /// </summary>
  public const ushort GrayResponseCurve = 0x0123;

  /// <summary>
  /// T.4-encoding options.
  /// </summary>
  public const ushort T4Options = 0x0124;

  /// <summary>
  /// T.6-encoding options.
  /// </summary>
  public const ushort T6Options = 0x0125;

  /// <summary>
  /// The unit for measuring <XResolution> and <YResolution>. The same unit is used for both <XResolution> and <YResolution>. If the image resolution is unknown; 2 (inches) is designated.
  /// </summary>
  public const ushort ResolutionUnit = 0x0128;

  /// <summary>
  /// The page number of the page from which this image was scanned.
  /// </summary>
  public const ushort PageNumber = 0x0129;

  /// <summary>
  /// A transfer function for the image; described in tabular style. Normally this tag is not necessary; since color space is specified in the color space information tag (<ColorSpace>).
  /// </summary>
  public const ushort TransferFunction = 0x012d;

  /// <summary>
  /// This tag records the name and version of the software or firmware of the camera or image input device used to generate the image. The detailed format is not specified; but it is recommended that the example shown below be followed. When the field is left blank; it is treated as unknown.
  /// </summary>
  public const ushort Software = 0x0131;

  /// <summary>
  /// The date and time of image creation. In Exif standard; it is the date and time the file was changed.
  /// </summary>
  public const ushort DateTime = 0x0132;

  /// <summary>
  /// This tag records the name of the camera owner; photographer or image creator. The detailed format is not specified; but it is recommended that the information be written as in the example below for ease of Interoperability. When the field is left blank; it is treated as unknown. Ex.) "Camera owner; John Smith; Photographer; Michael Brown; Image creator; Ken James"
  /// </summary>
  public const ushort Artist = 0x013b;

  /// <summary>
  /// This tag records information about the host computer used to generate the image.
  /// </summary>
  public const ushort HostComputer = 0x013c;

  /// <summary>
  /// A predictor is a mathematical operator that is applied to the image data before an encoding scheme is applied.
  /// </summary>
  public const ushort Predictor = 0x013d;

  /// <summary>
  /// The chromaticity of the white point of the image. Normally this tag is not necessary; since color space is specified in the colorspace information tag (<ColorSpace>).
  /// </summary>
  public const ushort WhitePoint = 0x013e;

  /// <summary>
  /// The chromaticity of the three primary colors of the image. Normally this tag is not necessary; since colorspace is specified in the colorspace information tag (<ColorSpace>).
  /// </summary>
  public const ushort PrimaryChromaticities = 0x013f;

  /// <summary>
  /// A color map for palette color images. This field defines a Red-Green-Blue color map (often called a lookup table) for palette-color images. In a palette-color image; a pixel value is used to index into an RGB lookup table.
  /// </summary>
  public const ushort ColorMap = 0x0140;

  /// <summary>
  /// The purpose of the HalftoneHints field is to convey to the halftone function the range of gray levels within a colorimetrically-specified image that should retain tonal detail.
  /// </summary>
  public const ushort HalftoneHints = 0x0141;

  /// <summary>
  /// The tile width in pixels. This is the number of columns in each tile.
  /// </summary>
  public const ushort TileWidth = 0x0142;

  /// <summary>
  /// The tile length (height) in pixels. This is the number of rows in each tile.
  /// </summary>
  public const ushort TileLength = 0x0143;

  /// <summary>
  /// For each tile; the byte offset of that tile; as compressed and stored on disk. The offset is specified with respect to the beginning of the TIFF file. Note that this implies that each tile has a location independent of the locations of other tiles.
  /// </summary>
  public const ushort TileOffsets = 0x0144;

  /// <summary>
  /// For each tile; the number of (compressed) bytes in that tile. See TileOffsets for a description of how the byte counts are ordered.
  /// </summary>
  public const ushort TileByteCounts = 0x0145;

  /// <summary>
  /// The set of inks used in a separated (PhotometricInterpretation=5) image.
  /// </summary>
  public const ushort InkSet = 0x014c;

  /// <summary>
  /// The name of each ink used in a separated (PhotometricInterpretation=5) image.
  /// </summary>
  public const ushort InkNames = 0x014d;

  /// <summary>
  /// The number of inks. Usually equal to SamplesPerPixel; unless there are extra samples.
  /// </summary>
  public const ushort NumberOfInks = 0x014e;

  /// <summary>
  /// The component values that correspond to a 0% dot and 100% dot.
  /// </summary>
  public const ushort DotRange = 0x0150;

  /// <summary>
  /// A description of the printing environment for which this separation is intended.
  /// </summary>
  public const ushort TargetPrinter = 0x0151;

  /// <summary>
  /// Specifies that each pixel has m extra components whose interpretation is defined by one of the values listed below.
  /// </summary>
  public const ushort ExtraSamples = 0x0152;

  /// <summary>
  /// This field specifies how to interpret each data sample in a pixel.
  /// </summary>
  public const ushort SampleFormat = 0x0153;

  /// <summary>
  /// This field specifies the minimum sample value.
  /// </summary>
  public const ushort SMinSampleValue = 0x0154;

  /// <summary>
  /// This field specifies the maximum sample value.
  /// </summary>
  public const ushort SMaxSampleValue = 0x0155;

  /// <summary>
  /// Expands the range of the TransferFunction
  /// </summary>
  public const ushort TransferRange = 0x0156;

  /// <summary>
  /// A TIFF ClipPath is intended to mirror the essentials of PostScript's path creation functionality.
  /// </summary>
  public const ushort ClipPath = 0x0157;

  /// <summary>
  /// The number of units that span the width of the image; in terms of integer ClipPath coordinates.
  /// </summary>
  public const ushort XClipPathUnits = 0x0158;

  /// <summary>
  /// The number of units that span the height of the image; in terms of integer ClipPath coordinates.
  /// </summary>
  public const ushort YClipPathUnits = 0x0159;

  /// <summary>
  /// Indexed images are images where the 'pixels' do not represent color values; but rather an index (usually 8-bit) into a separate color table; the ColorMap.
  /// </summary>
  public const ushort Indexed = 0x015a;

  /// <summary>
  /// (undefined type) This optional tag may be used to encode the JPEG quantization and Huffman tables for subsequent use by the JPEG decompression process.
  /// </summary>
  public const ushort JPEGTables = 0x015b;

  /// <summary>
  /// OPIProxy gives information concerning whether this image is a low-resolution proxy of a high-resolution image (Adobe OPI).
  /// </summary>
  public const ushort OPIProxy = 0x015f;

  /// <summary>
  /// This field indicates the process used to produce the compressed data
  /// </summary>
  public const ushort JPEGProc = 0x0200;

  /// <summary>
  /// The offset to the start byte (SOI) of JPEG compressed thumbnail data. This is not used for primary image JPEG data.
  /// </summary>
  public const ushort JPEGInterchangeFormat = 0x0201;

  /// <summary>
  /// The number of bytes of JPEG compressed thumbnail data. This is not used for primary image JPEG data. JPEG thumbnails are not divided but are recorded as a continuous JPEG bitstream from SOI to EOI. Appn and COM markers should not be recorded. Compressed thumbnails must be recorded in no more than 64 Kbytes; including all other data to be recorded in APP1.
  /// </summary>
  public const ushort JPEGInterchangeFormatLength = 0x0202;

  /// <summary>
  /// This Field indicates the length of the restart interval used in the compressed image data.
  /// </summary>
  public const ushort JPEGRestartInterval = 0x0203;

  /// <summary>
  /// This Field points to a list of lossless predictor-selection values; one per component.
  /// </summary>
  public const ushort JPEGLosslessPredictors = 0x0205;

  /// <summary>
  /// This Field points to a list of point transform values; one per component.
  /// </summary>
  public const ushort JPEGPointTransforms = 0x0206;

  /// <summary>
  /// This Field points to a list of offsets to the quantization tables; one per component.
  /// </summary>
  public const ushort JPEGQTables = 0x0207;

  /// <summary>
  /// This Field points to a list of offsets to the DC Huffman tables or the lossless Huffman tables; one per component.
  /// </summary>
  public const ushort JPEGDCTables = 0x0208;

  /// <summary>
  /// This Field points to a list of offsets to the Huffman AC tables; one per component.
  /// </summary>
  public const ushort JPEGACTables = 0x0209;

  /// <summary>
  /// The matrix coefficients for transformation from RGB to YCbCr image data. No default is given in TIFF; but here the value given in Appendix E; "Color Space Guidelines"; is used as the default. The color space is declared in a color space information tag; with the default being the value that gives the optimal image characteristics Interoperability this condition.
  /// </summary>
  public const ushort YCbCrCoefficients = 0x0211;

  /// <summary>
  /// The sampling ratio of chrominance components in relation to the luminance component. In JPEG compressed data a JPEG marker is used instead of this tag.
  /// </summary>
  public const ushort YCbCrSubSampling = 0x0212;

  /// <summary>
  /// The position of chrominance components in relation to the luminance component. This field is designated only for JPEG compressed data or uncompressed YCbCr data. The TIFF default is 1 (centered); but when Y:Cb:Cr = 4:2:2 it is recommended in this standard that 2 (co-sited) be used to record data; in order to improve the image quality when viewed on TV systems. When this field does not exist; the reader shall assume the TIFF default. In the case of Y:Cb:Cr = 4:2:0; the TIFF default (centered) is recommended. If the reader does not have the capability of supporting both kinds of <YCbCrPositioning>; it shall follow the TIFF default regardless of the value in this field. It is preferable that readers be able to support both centered and co-sited positioning.
  /// </summary>
  public const ushort YCbCrPositioning = 0x0213;

  /// <summary>
  /// The reference black point value and reference white point value. No defaults are given in TIFF; but the values below are given as defaults here. The color space is declared in a color space information tag; with the default being the value that gives the optimal image characteristics Interoperability these conditions.
  /// </summary>
  public const ushort ReferenceBlackWhite = 0x0214;

  /// <summary>
  /// XMP Metadata (Adobe technote 9-14-02)
  /// </summary>
  public const ushort XMLPacket = 0x02bc;

  /// <summary>
  /// Rating tag used by Windows
  /// </summary>
  public const ushort Rating = 0x4746;

  /// <summary>
  /// Rating tag used by Windows; value in percent
  /// </summary>
  public const ushort RatingPercent = 0x4749;

  /// <summary>
  /// Sony vignetting correction parameters
  /// </summary>
  public const ushort VignettingCorrParams = 0x7032;

  /// <summary>
  /// Sony chromatic aberration correction parameters
  /// </summary>
  public const ushort ChromaticAberrationCorrParams = 0x7035;

  /// <summary>
  /// Sony distortion correction parameters
  /// </summary>
  public const ushort DistortionCorrParams = 0x7037;

  /// <summary>
  /// ImageID is the full pathname of the original; high-resolution image; or any other identifying string that uniquely identifies the original image (Adobe OPI).
  /// </summary>
  public const ushort ImageID = 0x800d;

  /// <summary>
  /// Contains two values representing the minimum rows and columns to define the repeating patterns of the color filter array
  /// </summary>
  public const ushort CFARepeatPatternDim = 0x828d;

  /// <summary>
  /// Indicates the color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used. It does not apply to all sensing methods
  /// </summary>
  public const ushort CFAPattern = 0x828e;

  /// <summary>
  /// Contains a value of the battery level as a fraction or string
  /// </summary>
  public const ushort BatteryLevel = 0x828f;

  /// <summary>
  /// Copyright information. In this standard the tag is used to indicate both the photographer and editor copyrights. It is the copyright notice of the person or organization claiming rights to the image. The Interoperability copyright statement including date and rights should be written in this field; e.g.; "Copyright; John Smith; 19xx. All rights reserved.". In this standard the field records both the photographer and editor copyrights; with each recorded in a separate part of the statement. When there is a clear distinction between the photographer and editor copyrights; these are to be written in the order of photographer followed by editor copyright; separated by NULL (in this case since the statement also ends with a NULL; there are two NULL codes). When only the photographer copyright is given; it is terminated by one NULL code. When only the editor copyright is given; the photographer copyright part consists of one space followed by a terminating NULL code; then the editor copyright is given. When the field is left blank; it is treated as unknown.
  /// </summary>
  public const ushort Copyright = 0x8298;

  /// <summary>
  /// Exposure time; given in seconds.
  /// </summary>
  public const ushort ExposureTime = 0x829a;

  /// <summary>
  /// The F number.
  /// </summary>
  public const ushort FNumber = 0x829d;

  /// <summary>
  /// Contains an IPTC/NAA record
  /// </summary>
  public const ushort IPTCNAA = 0x83bb;

  /// <summary>
  /// Contains information embedded by the Adobe Photoshop application
  /// </summary>
  public const ushort ImageResources = 0x8649;

  /// <summary>
  /// (undefined type) Contains an InterColor Consortium (ICC) format color space characterization/profile
  /// </summary>
  public const ushort InterColorProfile = 0x8773;

  /// <summary>
  /// The class of the program used by the camera to set exposure when the picture is taken.
  /// </summary>
  public const ushort ExposureProgram = 0x8822;

  /// <summary>
  /// Indicates the spectral sensitivity of each channel of the camera used.
  /// </summary>
  public const ushort SpectralSensitivity = 0x8824;

  /// <summary>
  /// Indicates the ISO Speed and ISO Latitude of the camera or input device as specified in ISO 12232.
  /// </summary>
  public const ushort ISOSpeedRatings = 0x8827;

  /// <summary>
  /// (undefined type) Indicates the Opto-Electric Conversion Function (OECF) specified in ISO 14524.
  /// </summary>
  public const ushort OECF = 0x8828;

  /// <summary>
  /// Indicates the field number of multifield images.
  /// </summary>
  public const ushort Interlace = 0x8829;

  /// <summary>
  /// This optional tag encodes the time zone of the camera clock (relative to Greenwich Mean Time) used to create the DataTimeOriginal tag-value when the picture was taken. It may also contain the time zone offset of the clock used to create the DateTime tag-value when the image was modified.
  /// </summary>
  public const ushort TimeZoneOffset = 0x882a;

  /// <summary>
  /// Number of seconds image capture was delayed from button press.
  /// </summary>
  public const ushort SelfTimerMode = 0x882b;

  /// <summary>
  /// The date and time when the original image data was generated.
  /// </summary>
  public const ushort DateTimeOriginal = 0x9003;

  /// <summary>
  /// Specific to compressed data; states the compressed bits per pixel.
  /// </summary>
  public const ushort CompressedBitsPerPixel = 0x9102;

  /// <summary>
  /// Shutter speed.
  /// </summary>
  public const ushort ShutterSpeedValue = 0x9201;

  /// <summary>
  /// The lens aperture.
  /// </summary>
  public const ushort ApertureValue = 0x9202;

  /// <summary>
  /// The value of brightness.
  /// </summary>
  public const ushort BrightnessValue = 0x9203;

  /// <summary>
  /// The exposure bias.
  /// </summary>
  public const ushort ExposureBiasValue = 0x9204;

  /// <summary>
  /// The smallest F number of the lens.
  /// </summary>
  public const ushort MaxApertureValue = 0x9205;

  /// <summary>
  /// The distance to the subject; given in meters.
  /// </summary>
  public const ushort SubjectDistance = 0x9206;

  /// <summary>
  /// The metering mode.
  /// </summary>
  public const ushort MeteringMode = 0x9207;

  /// <summary>
  /// The kind of light source.
  /// </summary>
  public const ushort LightSource = 0x9208;

  /// <summary>
  /// Indicates the status of flash when the image was shot.
  /// </summary>
  public const ushort Flash = 0x9209;

  /// <summary>
  /// The actual focal length of the lens; in mm.
  /// </summary>
  public const ushort FocalLength = 0x920a;

  /// <summary>
  /// Amount of flash energy (BCPS).
  /// </summary>
  public const ushort FlashEnergy = 0x920b;

  /// <summary>
  /// (undefined type) SFR of the camera.
  /// </summary>
  public const ushort SpatialFrequencyResponse = 0x920c;

  /// <summary>
  /// (undefined type) Noise measurement values.
  /// </summary>
  public const ushort Noise = 0x920d;

  /// <summary>
  /// Number of pixels per FocalPlaneResolutionUnit (37392) in ImageWidth direction for main image.
  /// </summary>
  public const ushort FocalPlaneXResolution = 0x920e;

  /// <summary>
  /// Number of pixels per FocalPlaneResolutionUnit (37392) in ImageLength direction for main image.
  /// </summary>
  public const ushort FocalPlaneYResolution = 0x920f;

  /// <summary>
  /// Unit of measurement for FocalPlaneXResolution(37390) and FocalPlaneYResolution(37391).
  /// </summary>
  public const ushort FocalPlaneResolutionUnit = 0x9210;

  /// <summary>
  /// Number assigned to an image; e.g.; in a chained image burst.
  /// </summary>
  public const ushort ImageNumber = 0x9211;

  /// <summary>
  /// Security classification assigned to the image.
  /// </summary>
  public const ushort SecurityClassification = 0x9212;

  /// <summary>
  /// Record of what has been done to the image.
  /// </summary>
  public const ushort ImageHistory = 0x9213;

  /// <summary>
  /// Indicates the location and area of the main subject in the overall scene.
  /// </summary>
  public const ushort SubjectLocation = 0x9214;

  /// <summary>
  /// Encodes the camera exposure index setting when image was captured.
  /// </summary>
  public const ushort ExposureIndex = 0x9215;

  /// <summary>
  /// Contains four ASCII characters representing the TIFF/EP standard version of a TIFF/EP file; eg '1'; '0'; '0'; '0'
  /// </summary>
  public const ushort TIFFEPStandardID = 0x9216;

  /// <summary>
  /// Type of image sensor.
  /// </summary>
  public const ushort SensingMethod = 0x9217;

  /// <summary>
  /// Title tag used by Windows; encoded in UCS2
  /// </summary>
  public const ushort XPTitle = 0x9c9b;

  /// <summary>
  /// Comment tag used by Windows; encoded in UCS2
  /// </summary>
  public const ushort XPComment = 0x9c9c;

  /// <summary>
  /// Author tag used by Windows; encoded in UCS2
  /// </summary>
  public const ushort XPAuthor = 0x9c9d;

  /// <summary>
  /// Keywords tag used by Windows; encoded in UCS2
  /// </summary>
  public const ushort XPKeywords = 0x9c9e;

  /// <summary>
  /// Subject tag used by Windows; encoded in UCS2
  /// </summary>
  public const ushort XPSubject = 0x9c9f;

  /// <summary>
  /// (undefined type) Print Image Matching; description needed.
  /// </summary>
  public const ushort PrintImageMatching = 0xc4a5;

  /// <summary>
  /// This tag encodes the DNG four-tier version number. For files compliant with version 1.1.0.0 of the DNG specification; this tag should contain the bytes: 1; 1; 0; 0.
  /// </summary>
  public const ushort DNGVersion = 0xc612;

  /// <summary>
  /// This tag specifies the oldest version of the Digital Negative specification for which a file is compatible. Readers shouldnot attempt to read a file if this tag specifies a version number that is higher than the version number of the specification the reader was based on. In addition to checking the version tags; readers should; for all tags; check the types; counts; and values; to verify it is able to correctly read the file.
  /// </summary>
  public const ushort DNGBackwardVersion = 0xc613;

  /// <summary>
  /// Defines a unique; non-localized name for the camera model that created the image in the raw file. This name should include the manufacturer's name to avoid conflicts; and should not be localized; even if the camera name itself is localized for different markets (see LocalizedCameraModel). This string may be used by reader software to index into per-model preferences and replacement profiles.
  /// </summary>
  public const ushort UniqueCameraModel = 0xc614;

  /// <summary>
  /// Similar to the UniqueCameraModel field; except the name can be localized for different markets to match the localization of the camera name.
  /// </summary>
  public const ushort LocalizedCameraModel = 0xc615;

  /// <summary>
  /// Provides a mapping between the values in the CFAPattern tag and the plane numbers in LinearRaw space. This is a required tag for non-RGB CFA images.
  /// </summary>
  public const ushort CFAPlaneColor = 0xc616;

  /// <summary>
  /// Describes the spatial layout of the CFA.
  /// </summary>
  public const ushort CFALayout = 0xc617;

  /// <summary>
  /// Describes a lookup table that maps stored values into linear values. This tag is typically used to increase compression ratios by storing the raw data in a non-linear; more visually uniform space with fewer total encoding levels. If SamplesPerPixel is not equal to one; this single table applies to all the samples for each pixel.
  /// </summary>
  public const ushort LinearizationTable = 0xc618;

  /// <summary>
  /// Specifies repeat pattern size for the BlackLevel tag.
  /// </summary>
  public const ushort BlackLevelRepeatDim = 0xc619;

  /// <summary>
  /// Specifies the zero light (a.k.a. thermal black or black current) encoding level; as a repeating pattern. The origin of this pattern is the top-left corner of the ActiveArea rectangle. The values are stored in row-column-sample scan order.
  /// </summary>
  public const ushort BlackLevel = 0xc61a;

  /// <summary>
  /// If the zero light encoding level is a function of the image column; BlackLevelDeltaH specifies the difference between the zero light encoding level for each column and the baseline zero light encoding level. If SamplesPerPixel is not equal to one; this single table applies to all the samples for each pixel.
  /// </summary>
  public const ushort BlackLevelDeltaH = 0xc61b;

  /// <summary>
  /// If the zero light encoding level is a function of the image row; this tag specifies the difference between the zero light encoding level for each row and the baseline zero light encoding level. If SamplesPerPixel is not equal to one; this single table applies to all the samples for each pixel.
  /// </summary>
  public const ushort BlackLevelDeltaV = 0xc61c;

  /// <summary>
  /// This tag specifies the fully saturated encoding level for the raw sample values. Saturation is caused either by the sensor itself becoming highly non-linear in response; or by the camera's analog to digital converter clipping.
  /// </summary>
  public const ushort WhiteLevel = 0xc61d;

  /// <summary>
  /// DefaultScale is required for cameras with non-square pixels. It specifies the default scale factors for each direction to convert the image to square pixels. Typically these factors are selected to approximately preserve total pixel count. For CFA images that use CFALayout equal to 2; 3; 4; or 5; such as the Fujifilm SuperCCD; these two values should usually differ by a factor of 2.0.
  /// </summary>
  public const ushort DefaultScale = 0xc61e;

  /// <summary>
  /// Raw images often store extra pixels around the edges of the final image. These extra pixels help prevent interpolation artifacts near the edges of the final image. DefaultCropOrigin specifies the origin of the final image area; in raw image coordinates (i.e.; before the DefaultScale has been applied); relative to the top-left corner of the ActiveArea rectangle.
  /// </summary>
  public const ushort DefaultCropOrigin = 0xc61f;

  /// <summary>
  /// Raw images often store extra pixels around the edges of the final image. These extra pixels help prevent interpolation artifacts near the edges of the final image. DefaultCropSize specifies the size of the final image area; in raw image coordinates (i.e.; before the DefaultScale has been applied).
  /// </summary>
  public const ushort DefaultCropSize = 0xc620;

  /// <summary>
  /// ColorMatrix1 defines a transformation matrix that converts XYZ values to reference camera native color space values; under the first calibration illuminant. The matrix values are stored in row scan order. The ColorMatrix1 tag is required for all non-monochrome DNG files.
  /// </summary>
  public const ushort ColorMatrix1 = 0xc621;

  /// <summary>
  /// ColorMatrix2 defines a transformation matrix that converts XYZ values to reference camera native color space values; under the second calibration illuminant. The matrix values are stored in row scan order.
  /// </summary>
  public const ushort ColorMatrix2 = 0xc622;

  /// <summary>
  /// CameraCalibration1 defines a calibration matrix that transforms reference camera native space values to individual camera native space values under the first calibration illuminant. The matrix is stored in row scan order. This matrix is stored separately from the matrix specified by the ColorMatrix1 tag to allow raw converters to swap in replacement color matrices based on UniqueCameraModel tag; while still taking advantage of any per-individual camera calibration performed by the camera manufacturer.
  /// </summary>
  public const ushort CameraCalibration1 = 0xc623;

  /// <summary>
  /// CameraCalibration2 defines a calibration matrix that transforms reference camera native space values to individual camera native space values under the second calibration illuminant. The matrix is stored in row scan order. This matrix is stored separately from the matrix specified by the ColorMatrix2 tag to allow raw converters to swap in replacement color matrices based on UniqueCameraModel tag; while still taking advantage of any per-individual camera calibration performed by the camera manufacturer.
  /// </summary>
  public const ushort CameraCalibration2 = 0xc624;

  /// <summary>
  /// ReductionMatrix1 defines a dimensionality reduction matrix for use as the first stage in converting color camera native space values to XYZ values; under the first calibration illuminant. This tag may only be used if ColorPlanes is greater than 3. The matrix is stored in row scan order.
  /// </summary>
  public const ushort ReductionMatrix1 = 0xc625;

  /// <summary>
  /// ReductionMatrix2 defines a dimensionality reduction matrix for use as the first stage in converting color camera native space values to XYZ values; under the second calibration illuminant. This tag may only be used if ColorPlanes is greater than 3. The matrix is stored in row scan order.
  /// </summary>
  public const ushort ReductionMatrix2 = 0xc626;

  /// <summary>
  /// Normally the stored raw values are not white balanced; since any digital white balancing will reduce the dynamic range of the final image if the user decides to later adjust the white balance; however; if camera hardware is capable of white balancing the color channels before the signal is digitized; it can improve the dynamic range of the final image. AnalogBalance defines the gain; either analog (recommended) or digital (not recommended) that has been applied the stored raw values.
  /// </summary>
  public const ushort AnalogBalance = 0xc627;

  /// <summary>
  /// Specifies the selected white balance at time of capture; encoded as the coordinates of a perfectly neutral color in linear reference space values. The inclusion of this tag precludes the inclusion of the AsShotWhiteXY tag.
  /// </summary>
  public const ushort AsShotNeutral = 0xc628;

  /// <summary>
  /// Specifies the selected white balance at time of capture; encoded as x-y chromaticity coordinates. The inclusion of this tag precludes the inclusion of the AsShotNeutral tag.
  /// </summary>
  public const ushort AsShotWhiteXY = 0xc629;

  /// <summary>
  /// Camera models vary in the trade-off they make between highlight headroom and shadow noise. Some leave a significant amount of highlight headroom during a normal exposure. This allows significant negative exposure compensation to be applied during raw conversion; but also means normal exposures will contain more shadow noise. Other models leave less headroom during normal exposures. This allows for less negative exposure compensation; but results in lower shadow noise for normal exposures. Because of these differences; a raw converter needs to vary the zero point of its exposure compensation control from model to model. BaselineExposure specifies by how much (in EV units) to move the zero point. Positive values result in brighter default results; while negative values result in darker default results.
  /// </summary>
  public const ushort BaselineExposure = 0xc62a;

  /// <summary>
  /// Specifies the relative noise level of the camera model at a baseline ISO value of 100; compared to a reference camera model. Since noise levels tend to vary approximately with the square root of the ISO value; a raw converter can use this value; combined with the current ISO; to estimate the relative noise level of the current image.
  /// </summary>
  public const ushort BaselineNoise = 0xc62b;

  /// <summary>
  /// Specifies the relative amount of sharpening required for this camera model; compared to a reference camera model. Camera models vary in the strengths of their anti-aliasing filters. Cameras with weak or no filters require less sharpening than cameras with strong anti-aliasing filters.
  /// </summary>
  public const ushort BaselineSharpness = 0xc62c;

  /// <summary>
  /// Only applies to CFA images using a Bayer pattern filter array. This tag specifies; in arbitrary units; how closely the values of the green pixels in the blue/green rows track the values of the green pixels in the red/green rows. A value of zero means the two kinds of green pixels track closely; while a non-zero value means they sometimes diverge. The useful range for this tag is from 0 (no divergence) to about 5000 (quite large divergence).
  /// </summary>
  public const ushort BayerGreenSplit = 0xc62d;

  /// <summary>
  /// Some sensors have an unpredictable non-linearity in their response as they near the upper limit of their encoding range. This non-linearity results in color shifts in the highlight areas of the resulting image unless the raw converter compensates for this effect. LinearResponseLimit specifies the fraction of the encoding range above which the response may become significantly non-linear.
  /// </summary>
  public const ushort LinearResponseLimit = 0xc62e;

  /// <summary>
  /// CameraSerialNumber contains the serial number of the camera or camera body that captured the image.
  /// </summary>
  public const ushort CameraSerialNumber = 0xc62f;

  /// <summary>
  /// Contains information about the lens that captured the image. If the minimum f-stops are unknown; they should be encoded as 0/0.
  /// </summary>
  public const ushort LensInfo = 0xc630;

  /// <summary>
  /// ChromaBlurRadius provides a hint to the DNG reader about how much chroma blur should be applied to the image. If this tag is omitted; the reader will use its default amount of chroma blurring. Normally this tag is only included for non-CFA images; since the amount of chroma blur required for mosaic images is highly dependent on the de-mosaic algorithm; in which case the DNG reader's default value is likely optimized for its particular de-mosaic algorithm.
  /// </summary>
  public const ushort ChromaBlurRadius = 0xc631;

  /// <summary>
  /// Provides a hint to the DNG reader about how strong the camera's anti-alias filter is. A value of 0.0 means no anti-alias filter (i.e.; the camera is prone to aliasing artifacts with some subjects); while a value of 1.0 means a strong anti-alias filter (i.e.; the camera almost never has aliasing artifacts).
  /// </summary>
  public const ushort AntiAliasStrength = 0xc632;

  /// <summary>
  /// This tag is used by Adobe Camera Raw to control the sensitivity of its 'Shadows' slider.
  /// </summary>
  public const ushort ShadowScale = 0xc633;

  /// <summary>
  /// Provides a way for camera manufacturers to store private data in the DNG file for use by their own raw converters; and to have that data preserved by programs that edit DNG files.
  /// </summary>
  public const ushort DNGPrivateData = 0xc634;

  /// <summary>
  /// MakerNoteSafety lets the DNG reader know whether the EXIF MakerNote tag is safe to preserve along with the rest of the EXIF data. File browsers and other image management software processing an image with a preserved MakerNote should be aware that any thumbnail image embedded in the MakerNote may be stale; and may not reflect the current state of the full size image.
  /// </summary>
  public const ushort MakerNoteSafety = 0xc635;

  /// <summary>
  /// The illuminant used for the first set of color calibration tags (ColorMatrix1; CameraCalibration1; ReductionMatrix1). The legal values for this tag are the same as the legal values for the LightSource EXIF tag. If set to 255 (Other); then the IFD must also include a IlluminantData1 tag to specify the x-y chromaticity or spectral power distribution function for this illuminant.
  /// </summary>
  public const ushort CalibrationIlluminant1 = 0xc65a;

  /// <summary>
  /// The illuminant used for an optional second set of color calibration tags (ColorMatrix2; CameraCalibration2; ReductionMatrix2). The legal values for this tag are the same as the legal values for the CalibrationIlluminant1 tag; however; if both are included; neither is allowed to have a value of 0 (unknown). If set to 255 (Other); then the IFD must also include a IlluminantData2 tag to specify the x-y chromaticity or spectral power distribution function for this illuminant.
  /// </summary>
  public const ushort CalibrationIlluminant2 = 0xc65b;

  /// <summary>
  /// For some cameras; the best possible image quality is not achieved by preserving the total pixel count during conversion. For example; Fujifilm SuperCCD images have maximum detail when their total pixel count is doubled. This tag specifies the amount by which the values of the DefaultScale tag need to be multiplied to achieve the best quality image size.
  /// </summary>
  public const ushort BestQualityScale = 0xc65c;

  /// <summary>
  /// This tag contains a 16-byte unique identifier for the raw image data in the DNG file. DNG readers can use this tag to recognize a particular raw image; even if the file's name or the metadata contained in the file has been changed. If a DNG writer creates such an identifier; it should do so using an algorithm that will ensure that it is very unlikely two different images will end up having the same identifier.
  /// </summary>
  public const ushort RawDataUniqueID = 0xc65d;

  /// <summary>
  /// If the DNG file was converted from a non-DNG raw file; then this tag contains the file name of that original raw file.
  /// </summary>
  public const ushort OriginalRawFileName = 0xc68b;

  /// <summary>
  /// (undefined type) If the DNG file was converted from a non-DNG raw file; then this tag contains the compressed contents of that original raw file. The contents of this tag always use the big-endian byte order. The tag contains a sequence of data blocks. Future versions of the DNG specification may define additional data blocks; so DNG readers should ignore extra bytes when parsing this tag. DNG readers should also detect the case where data blocks are missing from the end of the sequence; and should assume a default value for all the missing blocks. There are no padding or alignment bytes between data blocks.
  /// </summary>
  public const ushort OriginalRawFileData = 0xc68c;

  /// <summary>
  /// This rectangle defines the active (non-masked) pixels of the sensor. The order of the rectangle coordinates is: top; left; bottom; right.
  /// </summary>
  public const ushort ActiveArea = 0xc68d;

  /// <summary>
  /// This tag contains a list of non-overlapping rectangle coordinates of fully masked pixels; which can be optionally used by DNG readers to measure the black encoding level. The order of each rectangle's coordinates is: top; left; bottom; right. If the raw image data has already had its black encoding level subtracted; then this tag should not be used; since the masked pixels are no longer useful.
  /// </summary>
  public const ushort MaskedAreas = 0xc68e;

  /// <summary>
  /// (undefined type) This tag contains an ICC profile that; in conjunction with the AsShotPreProfileMatrix tag; provides the camera manufacturer with a way to specify a default color rendering from camera color space coordinates (linear reference values) into the ICC profile connection space. The ICC profile connection space is an output referred colorimetric space; whereas the other color calibration tags in DNG specify a conversion into a scene referred colorimetric space. This means that the rendering in this profile should include any desired tone and gamut mapping needed to convert between scene referred values and output referred values.
  /// </summary>
  public const ushort AsShotICCProfile = 0xc68f;

  /// <summary>
  /// This tag is used in conjunction with the AsShotICCProfile tag. It specifies a matrix that should be applied to the camera color space coordinates before processing the values through the ICC profile specified in the AsShotICCProfile tag. The matrix is stored in the row scan order. If ColorPlanes is greater than three; then this matrix can (but is not required to) reduce the dimensionality of the color data down to three components; in which case the AsShotICCProfile should have three rather than ColorPlanes input components.
  /// </summary>
  public const ushort AsShotPreProfileMatrix = 0xc690;

  /// <summary>
  /// (undefined type) This tag is used in conjunction with the CurrentPreProfileMatrix tag. The CurrentICCProfile and CurrentPreProfileMatrix tags have the same purpose and usage as the AsShotICCProfile and AsShotPreProfileMatrix tag pair; except they are for use by raw file editors rather than camera manufacturers.
  /// </summary>
  public const ushort CurrentICCProfile = 0xc691;

  /// <summary>
  /// This tag is used in conjunction with the CurrentICCProfile tag. The CurrentICCProfile and CurrentPreProfileMatrix tags have the same purpose and usage as the AsShotICCProfile and AsShotPreProfileMatrix tag pair; except they are for use by raw file editors rather than camera manufacturers.
  /// </summary>
  public const ushort CurrentPreProfileMatrix = 0xc692;

  /// <summary>
  /// The DNG color model documents a transform between camera colors and CIE XYZ values. This tag describes the colorimetric reference for the CIE XYZ values. 0 = The XYZ values are scene-referred. 1 = The XYZ values are output-referred; using the ICC profile perceptual dynamic range. This tag allows output-referred data to be stored in DNG files and still processed correctly by DNG readers.
  /// </summary>
  public const ushort ColorimetricReference = 0xc6bf;

  /// <summary>
  /// A UTF-8 encoded string associated with the CameraCalibration1 and CameraCalibration2 tags. The CameraCalibration1 and CameraCalibration2 tags should only be used in the DNG color transform if the string stored in the CameraCalibrationSignature tag exactly matches the string stored in the ProfileCalibrationSignature tag for the selected camera profile.
  /// </summary>
  public const ushort CameraCalibrationSignature = 0xc6f3;

  /// <summary>
  /// A UTF-8 encoded string associated with the camera profile tags. The CameraCalibration1 and CameraCalibration2 tags should only be used in the DNG color transfer if the string stored in the CameraCalibrationSignature tag exactly matches the string stored in the ProfileCalibrationSignature tag for the selected camera profile.
  /// </summary>
  public const ushort ProfileCalibrationSignature = 0xc6f4;

  /// <summary>
  /// A list of file offsets to extra Camera Profile IFDs. Note that the primary camera profile tags should be stored in IFD 0; and the ExtraCameraProfiles tag should only be used if there is more than one camera profile stored in the DNG file.
  /// </summary>
  public const ushort ExtraCameraProfiles = 0xc6f5;

  /// <summary>
  /// A UTF-8 encoded string containing the name of the "as shot" camera profile; if any.
  /// </summary>
  public const ushort AsShotProfileName = 0xc6f6;

  /// <summary>
  /// This tag indicates how much noise reduction has been applied to the raw data on a scale of 0.0 to 1.0. A 0.0 value indicates that no noise reduction has been applied. A 1.0 value indicates that the "ideal" amount of noise reduction has been applied; i.e. that the DNG reader should not apply additional noise reduction by default. A value of 0/0 indicates that this parameter is unknown.
  /// </summary>
  public const ushort NoiseReductionApplied = 0xc6f7;

  /// <summary>
  /// A UTF-8 encoded string containing the name of the camera profile. This tag is optional if there is only a single camera profile stored in the file but is required for all camera profiles if there is more than one camera profile stored in the file.
  /// </summary>
  public const ushort ProfileName = 0xc6f8;

  /// <summary>
  /// This tag specifies the number of input samples in each dimension of the hue/saturation/value mapping tables. The data for these tables are stored in ProfileHueSatMapData1; ProfileHueSatMapData2 and ProfileHueSatMapData3 tags. The most common case has ValueDivisions equal to 1; so only hue and saturation are used as inputs to the mapping table.
  /// </summary>
  public const ushort ProfileHueSatMapDims = 0xc6f9;

  /// <summary>
  /// This tag contains the data for the first hue/saturation/value mapping table. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees; the second entry is saturation scale factor; and the third entry is a value scale factor. The table entries are stored in the tag in nested loop order; with the value divisions in the outer loop; the hue divisions in the middle loop; and the saturation divisions in the inner loop. All zero input saturation entries are required to have a value scale factor of 1.0.
  /// </summary>
  public const ushort ProfileHueSatMapData1 = 0xc6fa;

  /// <summary>
  /// This tag contains the data for the second hue/saturation/value mapping table. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees; the second entry is a saturation scale factor; and the third entry is a value scale factor. The table entries are stored in the tag in nested loop order; with the value divisions in the outer loop; the hue divisions in the middle loop; and the saturation divisions in the inner loop. All zero input saturation entries are required to have a value scale factor of 1.0.
  /// </summary>
  public const ushort ProfileHueSatMapData2 = 0xc6fb;

  /// <summary>
  /// This tag contains a default tone curve that can be applied while processing the image as a starting point for user adjustments. The curve is specified as a list of 32-bit IEEE floating-point value pairs in linear gamma. Each sample has an input value in the range of 0.0 to 1.0; and an output value in the range of 0.0 to 1.0. The first sample is required to be (0.0; 0.0); and the last sample is required to be (1.0; 1.0). Interpolated the curve using a cubic spline.
  /// </summary>
  public const ushort ProfileToneCurve = 0xc6fc;

  /// <summary>
  /// This tag contains information about the usage rules for the associated camera profile.
  /// </summary>
  public const ushort ProfileEmbedPolicy = 0xc6fd;

  /// <summary>
  /// A UTF-8 encoded string containing the copyright information for the camera profile. This string always should be preserved along with the other camera profile tags.
  /// </summary>
  public const ushort ProfileCopyright = 0xc6fe;

  /// <summary>
  /// This tag defines a matrix that maps white balanced camera colors to XYZ D50 colors.
  /// </summary>
  public const ushort ForwardMatrix1 = 0xc714;

  /// <summary>
  /// This tag defines a matrix that maps white balanced camera colors to XYZ D50 colors.
  /// </summary>
  public const ushort ForwardMatrix2 = 0xc715;

  /// <summary>
  /// A UTF-8 encoded string containing the name of the application that created the preview stored in the IFD.
  /// </summary>
  public const ushort PreviewApplicationName = 0xc716;

  /// <summary>
  /// A UTF-8 encoded string containing the version number of the application that created the preview stored in the IFD.
  /// </summary>
  public const ushort PreviewApplicationVersion = 0xc717;

  /// <summary>
  /// A UTF-8 encoded string containing the name of the conversion settings (for example; snapshot name) used for the preview stored in the IFD.
  /// </summary>
  public const ushort PreviewSettingsName = 0xc718;

  /// <summary>
  /// A unique ID of the conversion settings (for example; MD5 digest) used to render the preview stored in the IFD.
  /// </summary>
  public const ushort PreviewSettingsDigest = 0xc719;

  /// <summary>
  /// This tag specifies the color space in which the rendered preview in this IFD is stored. The default value for this tag is sRGB for color previews and Gray Gamma 2.2 for monochrome previews.
  /// </summary>
  public const ushort PreviewColorSpace = 0xc71a;

  /// <summary>
  /// This tag is an ASCII string containing the name of the date/time at which the preview stored in the IFD was rendered. The date/time is encoded using ISO 8601 format.
  /// </summary>
  public const ushort PreviewDateTime = 0xc71b;

  /// <summary>
  /// (undefined type) This tag is an MD5 digest of the raw image data. All pixels in the image are processed in row-scan order. Each pixel is zero padded to 16 or 32 bits deep (16-bit for data less than or equal to 16 bits deep; 32-bit otherwise). The data for each pixel is processed in little-endian byte order.
  /// </summary>
  public const ushort RawImageDigest = 0xc71c;

  /// <summary>
  /// (undefined type) This tag is an MD5 digest of the data stored in the OriginalRawFileData tag.
  /// </summary>
  public const ushort OriginalRawFileDigest = 0xc71d;

  /// <summary>
  /// Normally; the pixels within a tile are stored in simple row-scan order. This tag specifies that the pixels within a tile should be grouped first into rectangular blocks of the specified size. These blocks are stored in row-scan order. Within each block; the pixels are stored in row-scan order. The use of a non-default value for this tag requires setting the DNGBackwardVersion tag to at least 1.2.0.0.
  /// </summary>
  public const ushort SubTileBlockSize = 0xc71e;

  /// <summary>
  /// This tag specifies that rows of the image are stored in interleaved order. The value of the tag specifies the number of interleaved fields. The use of a non-default value for this tag requires setting the DNGBackwardVersion tag to at least 1.2.0.0.
  /// </summary>
  public const ushort RowInterleaveFactor = 0xc71f;

  /// <summary>
  /// This tag specifies the number of input samples in each dimension of a default "look" table. The data for this table is stored in the ProfileLookTableData tag.
  /// </summary>
  public const ushort ProfileLookTableDims = 0xc725;

  /// <summary>
  /// This tag contains a default "look" table that can be applied while processing the image as a starting point for user adjustment. This table uses the same format as the tables stored in the ProfileHueSatMapData1 and ProfileHueSatMapData2 tags; and is applied in the same color space. However; it should be applied later in the processing pipe; after any exposure compensation and/or fill light stages; but before any tone curve stage. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees; the second entry is a saturation scale factor; and the third entry is a value scale factor. The table entries are stored in the tag in nested loop order; with the value divisions in the outer loop; the hue divisions in the middle loop; and the saturation divisions in the inner loop. All zero input saturation entries are required to have a value scale factor of 1.0.
  /// </summary>
  public const ushort ProfileLookTableData = 0xc726;

  /// <summary>
  /// (undefined type) Specifies the list of opcodes that should be applied to the raw image; as read directly from the file.
  /// </summary>
  public const ushort OpcodeList1 = 0xc740;

  /// <summary>
  /// (undefined type) Specifies the list of opcodes that should be applied to the raw image; just after it has been mapped to linear reference values.
  /// </summary>
  public const ushort OpcodeList2 = 0xc741;

  /// <summary>
  /// (undefined type) Specifies the list of opcodes that should be applied to the raw image; just after it has been demosaiced.
  /// </summary>
  public const ushort OpcodeList3 = 0xc74e;

  /// <summary>
  /// NoiseProfile describes the amount of noise in a raw image. Specifically; this tag models the amount of signal-dependent photon (shot) noise and signal-independent sensor readout noise; two common sources of noise in raw images. The model assumes that the noise is white and spatially independent; ignoring fixed pattern effects and other sources of noise (e.g.; pixel response non-uniformity; spatially-dependent thermal effects; etc.).
  /// </summary>
  public const ushort NoiseProfile = 0xc761;

  /// <summary>
  /// The optional TimeCodes tag shall contain an ordered array of time codes. All time codes shall be 8 bytes long and in binary format. The tag may contain from 1 to 10 time codes. When the tag contains more than one time code; the first one shall be the default time code. This specification does not prescribe how to use multiple time codes. Each time code shall be as defined for the 8-byte time code structure in SMPTE 331M-2004; Section 8.3. See also SMPTE 12-1-2008 and SMPTE 309-1999.
  /// </summary>
  public const ushort TimeCodes = 0xc763;

  /// <summary>
  /// The optional FrameRate tag shall specify the video frame rate in number of image frames per second; expressed as a signed rational number. The numerator shall be non-negative and the denominator shall be positive. This field value is identical to the sample rate field in SMPTE 377-1-2009.
  /// </summary>
  public const ushort FrameRate = 0xc764;

  /// <summary>
  /// The optional TStop tag shall specify the T-stop of the actual lens; expressed as an unsigned rational number. T-stop is also known as T-number or the photometric aperture of the lens. (F-number is the geometric aperture of the lens.) When the exact value is known; the T-stop shall be specified using a single number. Alternately; two numbers shall be used to indicate a T-stop range; in which case the first number shall be the minimum T-stop and the second number shall be the maximum T-stop.
  /// </summary>
  public const ushort TStop = 0xc772;

  /// <summary>
  /// The optional ReelName tag shall specify a name for a sequence of images; where each image in the sequence has a unique image identifier (including but not limited to file name; frame number; date time; time code).
  /// </summary>
  public const ushort ReelName = 0xc789;

  /// <summary>
  /// The optional CameraLabel tag shall specify a text label for how the camera is used or assigned in this clip. This tag is similar to CameraLabel in XMP.
  /// </summary>
  public const ushort CameraLabel = 0xc7a1;

  /// <summary>
  /// If this file is a proxy for a larger original DNG file; this tag specifics the default final size of the larger original file from which this proxy was generated. The default value for this tag is default final size of the current DNG file; which is DefaultCropSize * DefaultScale.
  /// </summary>
  public const ushort OriginalDefaultFinalSize = 0xc791;

  /// <summary>
  /// If this file is a proxy for a larger original DNG file; this tag specifics the best quality final size of the larger original file from which this proxy was generated. The default value for this tag is the OriginalDefaultFinalSize; if specified. Otherwise the default value for this tag is the best quality size of the current DNG file; which is DefaultCropSize * DefaultScale * BestQualityScale.
  /// </summary>
  public const ushort OriginalBestQualityFinalSize = 0xc792;

  /// <summary>
  /// If this file is a proxy for a larger original DNG file; this tag specifics the DefaultCropSize of the larger original file from which this proxy was generated. The default value for this tag is OriginalDefaultFinalSize; if specified. Otherwise; the default value for this tag is the DefaultCropSize of the current DNG file.
  /// </summary>
  public const ushort OriginalDefaultCropSize = 0xc793;

  /// <summary>
  /// Provides a way for color profiles to specify how indexing into a 3D HueSatMap is performed during raw conversion. This tag is not applicable to 2.5D HueSatMap tables (i.e.; where the Value dimension is 1).
  /// </summary>
  public const ushort ProfileHueSatMapEncoding = 0xc7a3;

  /// <summary>
  /// Provides a way for color profiles to specify how indexing into a 3D LookTable is performed during raw conversion. This tag is not applicable to a 2.5D LookTable (i.e.; where the Value dimension is 1).
  /// </summary>
  public const ushort ProfileLookTableEncoding = 0xc7a4;

  /// <summary>
  /// Provides a way for color profiles to increase or decrease exposure during raw conversion. BaselineExposureOffset specifies the amount (in EV units) to add to the BaselineExposure tag during image rendering. For example; if the BaselineExposure value for a given camera model is +0.3; and the BaselineExposureOffset value for a given camera profile used to render an image for that camera model is -0.7; then the actual default exposure value used during rendering will be +0.3 - 0.7 = -0.4.
  /// </summary>
  public const ushort BaselineExposureOffset = 0xc7a5;

  /// <summary>
  /// This optional tag in a color profile provides a hint to the raw converter regarding how to handle the black point (e.g.; flare subtraction) during rendering. If set to Auto; the raw converter should perform black subtraction during rendering. If set to None; the raw converter should not perform any black subtraction during rendering.
  /// </summary>
  public const ushort DefaultBlackRender = 0xc7a6;

  /// <summary>
  /// This tag is a modified MD5 digest of the raw image data. It has been updated from the algorithm used to compute the RawImageDigest tag be more multi-processor friendly; and to support lossy compression algorithms.
  /// </summary>
  public const ushort NewRawImageDigest = 0xc7a7;

  /// <summary>
  /// The gain (what number the sample values are multiplied by) between the main raw IFD and the preview IFD containing this tag.
  /// </summary>
  public const ushort RawToPreviewGain = 0xc7a8;

  /// <summary>
  /// Specifies a default user crop rectangle in relative coordinates. The values must satisfy: 0.0 <= top < bottom <= 1.0; 0.0 <= left < right <= 1.0.The default values of (top = 0; left = 0; bottom = 1; right = 1) correspond exactly to the default crop rectangle (as specified by the DefaultCropOrigin and DefaultCropSize tags).
  /// </summary>
  public const ushort DefaultUserCrop = 0xc7b5;

  /// <summary>
  /// Specifies the encoding of any depth data in the file. Can be unknown (apart from nearer distances being closer to zero; and farther distances being closer to the maximum value); linear (values vary linearly from zero representing DepthNear to the maximum value representing DepthFar); or inverse (values are stored inverse linearly; with zero representing DepthNear and the maximum value representing DepthFar).
  /// </summary>
  public const ushort DepthFormat = 0xc7e9;

  /// <summary>
  /// Specifies distance from the camera represented by the zero value in the depth map. 0/0 means unknown.
  /// </summary>
  public const ushort DepthNear = 0xc7ea;

  /// <summary>
  /// Specifies distance from the camera represented by the maximum value in the depth map. 0/0 means unknown. 1/0 means infinity; which is valid for unknown and inverse depth formats.
  /// </summary>
  public const ushort DepthFar = 0xc7eb;

  /// <summary>
  /// Specifies the measurement units for the DepthNear and DepthFar tags.
  /// </summary>
  public const ushort DepthUnits = 0xc7ec;

  /// <summary>
  /// Specifies the measurement geometry for the depth map. Can be unknown; measured along the optical axis; or measured along the optical ray passing through each pixel.
  /// </summary>
  public const ushort DepthMeasureType = 0xc7ed;

  /// <summary>
  /// A string that documents how the enhanced image data was processed.
  /// </summary>
  public const ushort EnhanceParams = 0xc7ee;

  /// <summary>
  /// (undefined type) Contains spatially varying gain tables that can be applied while processing the image as a starting point for user adjustments.
  /// </summary>
  public const ushort ProfileGainTableMap = 0xcd2d;

  /// <summary>
  /// A string that identifies the semantic mask.
  /// </summary>
  public const ushort SemanticName = 0xcd2e;

  /// <summary>
  /// A string that identifies a specific instance in a semantic mask.
  /// </summary>
  public const ushort SemanticInstanceID = 0xcd30;

  /// <summary>
  /// The illuminant used for an optional thrid set of color calibration tags (ColorMatrix3; CameraCalibration3; ReductionMatrix3). The legal values for this tag are the same as the legal values for the LightSource EXIF tag; CalibrationIlluminant1 and CalibrationIlluminant2 must also be present. If set to 255 (Other); then the IFD must also include a IlluminantData3 tag to specify the x-y chromaticity or spectral power distribution function for this illuminant.
  /// </summary>
  public const ushort CalibrationIlluminant3 = 0xcd31;

  /// <summary>
  /// CameraCalibration3 defines a calibration matrix that transforms reference camera native space values to individual camera native space values under the third calibration illuminant. The matrix is stored in row scan order. This matrix is stored separately from the matrix specified by the ColorMatrix3 tag to allow raw converters to swap in replacement color matrices based on UniqueCameraModel tag; while still taking advantage of any per-individual camera calibration performed by the camera manufacturer.
  /// </summary>
  public const ushort CameraCalibration3 = 0xcd32;

  /// <summary>
  /// ColorMatrix3 defines a transformation matrix that converts XYZ values to reference camera native color space values; under the third calibration illuminant. The matrix values are stored in row scan order.
  /// </summary>
  public const ushort ColorMatrix3 = 0xcd33;

  /// <summary>
  /// This tag defines a matrix that maps white balanced camera colors to XYZ D50 colors.
  /// </summary>
  public const ushort ForwardMatrix3 = 0xcd34;

  /// <summary>
  /// (undefined type) When the CalibrationIlluminant1 tag is set to 255 (Other); then the IlluminantData1 tag is required and specifies the data for the first illuminant. Otherwise; this tag is ignored. The illuminant data may be specified as either a x-y chromaticity coordinate or as a spectral power distribution function.
  /// </summary>
  public const ushort IlluminantData1 = 0xcd35;

  /// <summary>
  /// (undefined type) When the CalibrationIlluminant2 tag is set to 255 (Other); then the IlluminantData2 tag is required and specifies the data for the second illuminant. Otherwise; this tag is ignored. The format of the data is the same as IlluminantData1.
  /// </summary>
  public const ushort IlluminantData2 = 0xcd36;

  /// <summary>
  /// (undefined type) When the CalibrationIlluminant3 tag is set to 255 (Other); then the IlluminantData3 tag is required and specifies the data for the third illuminant. Otherwise; this tag is ignored. The format of the data is the same as IlluminantData1.
  /// </summary>
  public const ushort IlluminantData3 = 0xcd37;

  /// <summary>
  /// This tag contains the data for the third hue/saturation/value mapping table. Each entry of the table contains three 32-bit IEEE floating-point values. The first entry is hue shift in degrees; the second entry is saturation scale factor; and the third entry is a value scale factor. The table entries are stored in the tag in nested loop order; with the value divisions in the outer loop; the hue divisions in the middle loop; and the saturation divisions in the inner loop. All zero input saturation entries are required to have a value scale factor of 1.0.
  /// </summary>
  public const ushort ProfileHueSatMapData3 = 0xcd39;

  /// <summary>
  /// ReductionMatrix3 defines a dimensionality reduction matrix for use as the first stage in converting color camera native space values to XYZ values; under the third calibration illuminant. This tag may only be used if ColorPlanes is greater than 3. The matrix is stored in row scan order.
  /// </summary>
  public const ushort ReductionMatrix3 = 0xcd3a;


  //
  // Photo section

  /// <summary>
  /// Exposure time; given in seconds (sec).
  /// </summary>
  /// Duplicated with ExposureTime
  //PhotoExposureTime = 0x829a;

  /// <summary>
  /// The F number.
  /// </summary>
  /// Duplicated with FNumber
  //PhotoFNumber = 0x829d;

  /// <summary>
  /// The class of the program used by the camera to set exposure when the picture is taken.
  /// </summary>
  /// Duplicated with ExposureProgram
  //PhotoExposureProgram = 0x8822;

  /// <summary>
  /// Indicates the spectral sensitivity of each channel of the camera used. The tag value is an ASCII string compatible with the standard developed by the ASTM Technical Committee.
  /// </summary>
  /// Duplicated with SpectralSensitivity
  //PhotoSpectralSensitivity = 0x8824;

  /// <summary>
  /// Indicates the ISO Speed and ISO Latitude of the camera or input device as specified in ISO 12232.
  /// </summary>
  /// Duplicated with ISOSpeedRatings
  //PhotoISOSpeedRatings = 0x8827;

  /// <summary>
  /// (undefined type) Indicates the Opto-Electoric Conversion Function (OECF) specified in ISO 14524. <OECF> is the relationship between the camera optical input and the image values.
  /// </summary>
  /// Duplicated with OECF
  //PhotoOECF = 0x8828;

  /// <summary>
  /// The SensitivityType tag indicates which one of the parameters of ISO12232 is the PhotographicSensitivity tag. Although it is an optional tag; it should be recorded when a PhotographicSensitivity tag is recorded. Value = 4; 5; 6; or 7 may be used in case that the values of plural parameters are the same.
  /// </summary>
  public const ushort PhotoSensitivityType = 0x8830;

  /// <summary>
  /// This tag indicates the standard output sensitivity value of a camera or input device defined in ISO 12232. When recording this tag; the PhotographicSensitivity and SensitivityType tags shall also be recorded.
  /// </summary>
  public const ushort PhotoStandardOutputSensitivity = 0x8831;

  /// <summary>
  /// This tag indicates the recommended exposure index value of a camera or input device defined in ISO 12232. When recording this tag; the PhotographicSensitivity and SensitivityType tags shall also be recorded.
  /// </summary>
  public const ushort PhotoRecommendedExposureIndex = 0x8832;

  /// <summary>
  /// This tag indicates the ISO speed value of a camera or input device that is defined in ISO 12232. When recording this tag; the PhotographicSensitivity and SensitivityType tags shall also be recorded.
  /// </summary>
  public const ushort PhotoISOSpeed = 0x8833;

  /// <summary>
  /// This tag indicates the ISO speed latitude yyy value of a camera or input device that is defined in ISO 12232. However; this tag shall not be recorded without ISOSpeed and ISOSpeedLatitudezzz.
  /// </summary>
  public const ushort PhotoISOSpeedLatitudeyyy = 0x8834;

  /// <summary>
  /// This tag indicates the ISO speed latitude zzz value of a camera or input device that is defined in ISO 12232. However; this tag shall not be recorded without ISOSpeed and ISOSpeedLatitudeyyy.
  /// </summary>
  public const ushort PhotoISOSpeedLatitudezzz = 0x8835;

  /// <summary>
  /// (undefined type) The version of this standard supported. Nonexistence of this field is taken to mean nonconformance to the standard.
  /// </summary>
  public const ushort PhotoExifVersion = 0x9000;

  /// <summary>
  /// The date and time when the original image data was generated. For a digital still camera the date and time the picture was taken are recorded.
  /// </summary>
  /// Duplicated with DateTimeOriginal
  //PhotoDateTimeOriginal = 0x9003;

  /// <summary>
  /// The date and time when the image was stored as digital data.
  /// </summary>
  public const ushort PhotoDateTimeDigitized = 0x9004;

  /// <summary>
  /// Time difference from Universal Time Coordinated including daylight saving time of DateTime tag.
  /// </summary>
  public const ushort PhotoOffsetTime = 0x9010;

  /// <summary>
  /// Time difference from Universal Time Coordinated including daylight saving time of DateTimeOriginal tag.
  /// </summary>
  public const ushort PhotoOffsetTimeOriginal = 0x9011;

  /// <summary>
  /// Time difference from Universal Time Coordinated including daylight saving time of DateTimeDigitized tag.
  /// </summary>
  public const ushort PhotoOffsetTimeDigitized = 0x9012;

  /// <summary>
  /// (undefined type) Information specific to compressed data. The channels of each component are arranged in order from the 1st component to the 4th. For uncompressed data the data arrangement is given in the <PhotometricInterpretation> tag. However; since <PhotometricInterpretation> can only express the order of Y; Cb and Cr; this tag is provided for cases when compressed data uses components other than Y; Cb; and Cr and to enable support of other sequences.
  /// </summary>
  public const ushort PhotoComponentsConfiguration = 0x9101;

  /// <summary>
  /// Information specific to compressed data. The compression mode used for a compressed image is indicated in unit bits per pixel.
  /// </summary>
  /// Duplicated with CompressedBitsPerPixel
  //PhotoCompressedBitsPerPixel = 0x9102;

  /// <summary>
  /// Shutter speed. The unit is the APEX (Additive System of Photographic Exposure) setting.
  /// </summary>
  /// Duplicated with ShutterSpeedValue
  //PhotoShutterSpeedValue = 0x9201;

  /// <summary>
  /// The lens aperture. The unit is the APEX value.
  /// </summary>
  /// Duplicated with ApertureValue
  //PhotoApertureValue = 0x9202;

  /// <summary>
  /// The value of brightness. The unit is the APEX value. Ordinarily it is given in the range of -99.99 to 99.99.
  /// </summary>
  /// Duplicated with BrightnessValue
  //PhotoBrightnessValue = 0x9203;

  /// <summary>
  /// The exposure bias. The units is the APEX value. Ordinarily it is given in the range of -99.99 to 99.99.
  /// </summary>
  /// Duplicated with ExposureBiasValue
  //PhotoExposureBiasValue = 0x9204;

  /// <summary>
  /// The smallest F number of the lens. The unit is the APEX value. Ordinarily it is given in the range of 00.00 to 99.99; but it is not limited to this range.
  /// </summary>
  /// Duplicated with MaxApertureValue
  //PhotoMaxApertureValue = 0x9205;

  /// <summary>
  /// The distance to the subject; given in meters.
  /// </summary>
  /// Duplicated with SubjectDistance
  //PhotoSubjectDistance = 0x9206;

  /// <summary>
  /// The metering mode.
  /// </summary>
  /// Duplicated with MeteringMode
  //PhotoMeteringMode = 0x9207;

  /// <summary>
  /// The kind of light source.
  /// </summary>
  /// Duplicated with LightSource
  //PhotoLightSource = 0x9208;

  /// <summary>
  /// This tag is recorded when an image is taken using a strobe light (flash).
  /// </summary>
  /// Duplicated with Flash
  //PhotoFlash = 0x9209;

  /// <summary>
  /// The actual focal length of the lens; in mm. Conversion is not made to the focal length of a 35 mm film camera.
  /// </summary>
  /// Duplicated with FocalLength
  //PhotoFocalLength = 0x920a;

  /// <summary>
  /// This tag indicates the location and area of the main subject in the overall scene.
  /// </summary>
  /// Duplicated with SubjectLocation
  //PhotoSubjectArea = 0x9214;

  /// <summary>
  /// (undefined type) A tag for manufacturers of Exif writers to record any desired information. The contents are up to the manufacturer.
  /// </summary>
  public const ushort PhotoMakerNote = 0x927c;

  /// <summary>
  ///  // Comment - A tag for Exif users to write keywords or comments on the image besides those in <ImageDescription>; and without the character code limitations of the <ImageDescription> tag.
  /// </summary>
  public const ushort PhotoUserComment = 0x9286;

  /// <summary>
  /// A tag used to record fractions of seconds for the <DateTime> tag.
  /// </summary>
  public const ushort PhotoSubSecTime = 0x9290;

  /// <summary>
  /// A tag used to record fractions of seconds for the <DateTimeOriginal> tag.
  /// </summary>
  public const ushort PhotoSubSecTimeOriginal = 0x9291;

  /// <summary>
  /// A tag used to record fractions of seconds for the <DateTimeDigitized> tag.
  /// </summary>
  public const ushort PhotoSubSecTimeDigitized = 0x9292;

  /// <summary>
  /// Temperature as the ambient situation at the shot; for example the room temperature where the photographer was holding the camera. The unit is degrees C.
  /// </summary>
  public const ushort PhotoTemperature = 0x9400;

  /// <summary>
  /// Humidity as the ambient situation at the shot; for example the room humidity where the photographer was holding the camera. The unit is %.
  /// </summary>
  public const ushort PhotoHumidity = 0x9401;

  /// <summary>
  /// Pressure as the ambient situation at the shot; for example the room atmosphere where the photographer was holding the camera or the water pressure under the sea. The unit is hPa.
  /// </summary>
  public const ushort PhotoPressure = 0x9402;

  /// <summary>
  /// Water depth as the ambient situation at the shot; for example the water depth of the camera at underwater photography. The unit is m.
  /// </summary>
  public const ushort PhotoWaterDepth = 0x9403;

  /// <summary>
  /// Acceleration (a scalar regardless of direction) as the ambient situation at the shot; for example the driving acceleration of the vehicle which the photographer rode on at the shot. The unit is mGal (10e-5 m/s^2).
  /// </summary>
  public const ushort PhotoAcceleration = 0x9404;

  /// <summary>
  /// Elevation/depression. angle of the orientation of the camera(imaging optical axis) as the ambient situation at the shot. The unit is degrees.
  /// </summary>
  public const ushort PhotoCameraElevationAngle = 0x9405;

  /// <summary>
  /// (undefined type) The FlashPix format version supported by a FPXR file.
  /// </summary>
  public const ushort PhotoFlashpixVersion = 0xa000;

  /// <summary>
  /// The color space information tag is always recorded as the color space specifier. Normally sRGB is used to define the color space based on the PC monitor conditions and environment. If a color space other than sRGB is used; Uncalibrated is set. Image data recorded as Uncalibrated can be treated as sRGB when it is converted to FlashPix.
  /// </summary>
  public const ushort PhotoColorSpace = 0xa001;

  /// <summary>
  /// Information specific to compressed data. When a compressed file is recorded; the valid width of the meaningful image must be recorded in this tag; whether or not there is padding data or a restart marker. This tag should not exist in an uncompressed file.
  /// </summary>
  public const ushort PhotoPixelXDimension = 0xa002;

  /// <summary>
  /// Information specific to compressed data. When a compressed file is recorded; the valid height of the meaningful image must be recorded in this tag; whether or not there is padding data or a restart marker. This tag should not exist in an uncompressed file. Since data padding is unnecessary in the vertical direction; the number of lines recorded in this valid image height tag will in fact be the same as that recorded in the SOF.
  /// </summary>
  public const ushort PhotoPixelYDimension = 0xa003;

  /// <summary>
  /// This tag is used to record the name of an audio file related to the image data. The only relational information recorded here is the Exif audio file name and extension (an ASCII string consisting of 8 characters + '.' + 3 characters). The path is not recorded.
  /// </summary>
  public const ushort PhotoRelatedSoundFile = 0xa004;

  /// <summary>
  /// Indicates the strobe energy at the time the image is captured; as measured in Beam Candle Power Seconds (BCPS).
  /// </summary>
  public const ushort PhotoFlashEnergy = 0xa20b;

  /// <summary>
  /// (undefined type) This tag records the camera or input device spatial frequency table and SFR values in the direction of image width; image height; and diagonal direction; as specified in ISO 12233.
  /// </summary>
  public const ushort PhotoSpatialFrequencyResponse = 0xa20c;

  /// <summary>
  /// Indicates the number of pixels in the image width (X) direction per <FocalPlaneResolutionUnit> on the camera focal plane.
  /// </summary>
  public const ushort PhotoFocalPlaneXResolution = 0xa20e;

  /// <summary>
  /// Indicates the number of pixels in the image height (V) direction per <FocalPlaneResolutionUnit> on the camera focal plane.
  /// </summary>
  public const ushort PhotoFocalPlaneYResolution = 0xa20f;

  /// <summary>
  /// Indicates the unit for measuring <FocalPlaneXResolution> and <FocalPlaneYResolution>. This value is the same as the <ResolutionUnit>.
  /// </summary>
  public const ushort PhotoFocalPlaneResolutionUnit = 0xa210;

  /// <summary>
  /// Indicates the location of the main subject in the scene. The value of this tag represents the pixel at the center of the main subject relative to the left edge; prior to rotation processing as per the <Rotation> tag. The first value indicates the X column number and second indicates the Y row number.
  /// </summary>
  public const ushort PhotoSubjectLocation = 0xa214;

  /// <summary>
  /// Indicates the exposure index selected on the camera or input device at the time the image is captured.
  /// </summary>
  public const ushort PhotoExposureIndex = 0xa215;

  /// <summary>
  /// Indicates the image sensor type on the camera or input device.
  /// </summary>
  public const ushort PhotoSensingMethod = 0xa217;

  /// <summary>
  /// (undefined type) Indicates the image source. If a DSC recorded the image; this tag value of this tag always be set to 3; indicating that the image was recorded on a DSC.
  /// </summary>
  public const ushort PhotoFileSource = 0xa300;

  /// <summary>
  /// (undefined type) Indicates the type of scene. If a DSC recorded the image; this tag value must always be set to 1; indicating that the image was directly photographed.
  /// </summary>
  public const ushort PhotoSceneType = 0xa301;

  /// <summary>
  /// (undefined type) Indicates the color filter array (CFA) geometric pattern of the image sensor when a one-chip color area sensor is used. It does not apply to all sensing methods.
  /// </summary>
  public const ushort PhotoCFAPattern = 0xa302;

  /// <summary>
  /// This tag indicates the use of special processing on image data; such as rendering geared to output. When special processing is performed; the reader is expected to disable or minimize any further processing.
  /// </summary>
  public const ushort PhotoCustomRendered = 0xa401;

  /// <summary>
  /// This tag indicates the exposure mode set when the image was shot. In auto-bracketing mode; the camera shoots a series of frames of the same scene at different exposure settings.
  /// </summary>
  public const ushort PhotoExposureMode = 0xa402;

  /// <summary>
  /// This tag indicates the white balance mode set when the image was shot.
  /// </summary>
  public const ushort PhotoWhiteBalance = 0xa403;

  /// <summary>
  /// This tag indicates the digital zoom ratio when the image was shot. If the numerator of the recorded value is 0; this indicates that digital zoom was not used.
  /// </summary>
  public const ushort PhotoDigitalZoomRatio = 0xa404;

  /// <summary>
  /// This tag indicates the equivalent focal length assuming a 35mm film camera; in mm. A value of 0 means the focal length is unknown. Note that this tag differs from the <FocalLength> tag.
  /// </summary>
  public const ushort PhotoFocalLengthIn35mmFilm = 0xa405;

  /// <summary>
  /// This tag indicates the type of scene that was shot. It can also be used to record the mode in which the image was shot. Note that this differs from the <SceneType> tag.
  /// </summary>
  public const ushort PhotoSceneCaptureType = 0xa406;

  /// <summary>
  /// This tag indicates the degree of overall image gain adjustment.
  /// </summary>
  public const ushort PhotoGainControl = 0xa407;

  /// <summary>
  /// This tag indicates the direction of contrast processing applied by the camera when the image was shot.
  /// </summary>
  public const ushort PhotoContrast = 0xa408;

  /// <summary>
  /// This tag indicates the direction of saturation processing applied by the camera when the image was shot.
  /// </summary>
  public const ushort PhotoSaturation = 0xa409;

  /// <summary>
  /// This tag indicates the direction of sharpness processing applied by the camera when the image was shot.
  /// </summary>
  public const ushort PhotoSharpness = 0xa40a;

  /// <summary>
  /// (undefined type) This tag indicates information on the picture-taking conditions of a particular camera model. The tag is used only to indicate the picture-taking conditions in the reader.
  /// </summary>
  public const ushort PhotoDeviceSettingDescription = 0xa40b;

  /// <summary>
  /// This tag indicates the distance to the subject.
  /// </summary>
  public const ushort PhotoSubjectDistanceRange = 0xa40c;

  /// <summary>
  /// This tag indicates an identifier assigned uniquely to each image. It is recorded as an ASCII string equivalent to hexadecimal notation and 128-bit fixed length.
  /// </summary>
  public const ushort PhotoImageUniqueID = 0xa420;

  /// <summary>
  /// This tag records the owner of a camera used in photography as an ASCII string.
  /// </summary>
  public const ushort PhotoCameraOwnerName = 0xa430;

  /// <summary>
  /// This tag records the serial number of the body of the camera that was used in photography as an ASCII string.
  /// </summary>
  public const ushort PhotoBodySerialNumber = 0xa431;

  /// <summary>
  /// This tag notes minimum focal length; maximum focal length; minimum F number in the minimum focal length; and minimum F number in the maximum focal length; which are specification information for the lens that was used in photography. When the minimum F number is unknown; the notation is 0/0
  /// </summary>
  public const ushort PhotoLensSpecification = 0xa432;

  /// <summary>
  /// This tag records the lens manufactor as an ASCII string.
  /// </summary>
  public const ushort PhotoLensMake = 0xa433;

  /// <summary>
  /// This tag records the lens's model name and model number as an ASCII string.
  /// </summary>
  public const ushort PhotoLensModel = 0xa434;

  /// <summary>
  /// This tag records the serial number of the interchangeable lens that was used in photography as an ASCII string.
  /// </summary>
  public const ushort PhotoLensSerialNumber = 0xa435;

  /// <summary>
  /// Indicates whether the recorded image is a composite image or not.
  /// </summary>
  public const ushort PhotoCompositeImage = 0xa460;

  /// <summary>
  /// Indicates the number of the source images (tentatively recorded images) captured for a composite Image.
  /// </summary>
  public const ushort PhotoSourceImageNumberOfCompositeImage = 0xa461;

  /// <summary>
  /// (undefined type) For a composite image; records the parameters relating exposure time of the exposures for generating the said composite image; such as respective exposure times of captured source images (tentatively recorded images).
  /// </summary>
  public const ushort PhotoSourceExposureTimesOfCompositeImage = 0xa462;

  /// <summary>
  /// Indicates the value of coefficient gamma. The formula of transfer function used for image reproduction is expressed as follows: (reproduced value) = (input value)^gamma. Both reproduced value and input value indicate normalized value; whose minimum value is 0 and maximum value is 1.
  /// </summary>
  public const ushort PhotoGamma = 0xa500;


  //
  // GPS section

  /// <summary>
  /// Indicates the version of <GPSInfoIFD>. The version is given as 2.0.0.0. This tag is mandatory when <GPSInfo> tag is present. (Note: The <GPSVersionID> tag is given in bytes; unlike the <ExifVersion> tag. When the version is 2.0.0.0; the tag value is 02000000.H).
  /// </summary>
  [ExifTagDetails( "GPS Version ID", "Indicates the version of the GPS Info IFD" )]
  public const ushort GPSVersionID = 0x0000;

  /// <summary>
  /// Indicates whether the latitude is north or south latitude. The ASCII value 'N' indicates north latitude; and 'S' is south latitude.
  /// </summary>
  [ExifTagDetails( "GPS Latitude Reference", "Indicates whether the latitude is North or South longitude; 'N' denotes North longitude, 'S' denotes South longitude" )]
  public const ushort GPSLatitudeRef = 0x0001;

  /// <summary>
  /// Indicates the latitude. The latitude is expressed as three RATIONAL values giving the degrees; minutes; and seconds; respectively. When degrees; minutes and seconds are expressed; the format is dd/1;mm/1;ss/1. When degrees and minutes are used and; for example; fractions of minutes are given up to two decimal places; the format is dd/1;mmmm/100;0/1.
  /// </summary>
  [ExifTagDetails( "GPS Latitude", "Indicates the latitude as three Rational values giving the degress, minutes and seconds respectively" )]
  public const ushort GPSLatitude = 0x0002;

  /// <summary>
  /// Indicates whether the longitude is east or west longitude. ASCII 'E' indicates east longitude; and 'W' is west longitude.
  /// </summary>
  [ExifTagDetails( "GPS Longitude Reference", "Indicates whether the longitude is East or West longitude; 'E' denotes East longitude, 'W' denotes West longitude" )]
  public const ushort GPSLongitudeRef = 0x0003;

  /// <summary>
  /// Indicates the longitude. The longitude is expressed as three RATIONAL values giving the degrees; minutes; and seconds; respectively. When degrees; minutes and seconds are expressed; the format is ddd/1;mm/1;ss/1. When degrees and minutes are used and; for example; fractions of minutes are given up to two decimal places; the format is ddd/1;mmmm/100;0/1.
  /// </summary>
  [ExifTagDetails( "GPS Longitude", "Indicates the longitude as three Rational values giving the degress, minutes and seconds respectively" )]
  public const ushort GPSLongitude = 0x0004;

  /// <summary>
  /// Indicates the altitude used as the reference altitude. If the reference is sea level and the altitude is above sea level; 0 is given. If the altitude is below sea level; a value of 1 is given and the altitude is indicated as an absolute value in the GSPAltitude tag. The reference unit is meters. Note that this tag is BYTE type; unlike other reference tags.
  /// </summary>
  [ExifTagDetails( "GPS Altitude Reference", "Indicates the altitude reference used for GPSAltitude; '0' denotes altitude above sea level, '1' denotes altitude below sea level" )]
  public const ushort GPSAltitudeRef = 0x0005;

  /// <summary>
  /// Indicates the altitude based on the reference in GPSAltitudeRef. Altitude is expressed as one RATIONAL value. The reference unit is meters.
  /// </summary>
  [ExifTagDetails( "GPS Altitude", "Indicates the altitude based on the reference in GPSAltitudeRef and expressed in meters" )]
  public const ushort GPSAltitude = 0x0006;

  /// <summary>
  /// Indicates the time as UTC (Coordinated Universal Time). <TimeStamp> is expressed as three RATIONAL values giving the hour; minute; and second (atomic clock).
  /// </summary>
  [ExifTagDetails( "GPS TimeStamp", "Indicates the UTC time expressed as three Rational values giving the hour, minute and second" )]
  public const ushort GPSTimeStamp = 0x0007;

  /// <summary>
  /// Indicates the GPS satellites used for measurements. This tag can be used to describe the number of satellites; their ID number; angle of elevation; azimuth; SNR and other information in ASCII notation. The format is not specified. If the GPS receiver is incapable of taking measurements; value of the tag is set to NULL.
  /// </summary>
  [ExifTagDetails( "GPS Satellites", "Indicates the GPS satellites used for measurements; the tag can be used to describe the number of satellites, their ID number, angle of elevation, azimuth, SNR and other information" )]
  public const ushort GPSSatellites = 0x0008;

  /// <summary>
  /// Indicates the status of the GPS receiver when the image is recorded. "A" means measurement is in progress; and "V" means the measurement is Interoperability.
  /// </summary>
  [ExifTagDetails( "GPS Status", "Indicates the status of the GPS receiver when the image is recorded; 'A' denotes measurement is in-progress, 'V' denotes the measurement is Interoperability" )]
  public const ushort GPSStatus = 0x0009;

  /// <summary>
  /// Indicates the GPS measurement mode. "2" means two-dimensional measurement and "3" means three-dimensional measurement is in progress.
  /// </summary>
  [ExifTagDetails( "GPS Measurement Mode", "Indicates the GPS measurement mode; '2' means two-dimensional, '3' means three-dimensional measurement is in progress" )]
  public const ushort GPSMeasureMode = 0x000a;

  /// <summary>
  /// Indicates the GPS DOP (data degree of precision). An HDOP value is written during two-dimensional measurement; and PDOP during three-dimensional measurement.
  /// </summary>
  [ExifTagDetails( "GPS Data Degree of Precision", "Indicates the GPS data degree of precision. An HDOP value is written during two-dimensional measurement; and PDOP during three-dimensional measurement" )]
  public const ushort GPSDOP = 0x000b;

  /// <summary>
  /// Indicates the unit used to express the GPS receiver speed of movement. "K" "M" and "N" represents kilometers per hour; miles per hour; and knots.
  /// </summary>
  [ExifTagDetails( "GPS Speed Reference", "Indicates the unit used to express the GPS receiver speed of movement; 'K' denotes km/h, 'M' denotes miles per hour, 'N' denotes knots" )]
  public const ushort GPSSpeedRef = 0x000c;

  /// <summary>
  /// Indicates the speed of GPS receiver movement.
  /// </summary>
  [ExifTagDetails( "GPS Speed", "Indicates the speed of GPS receiver movement" )]
  public const ushort GPSSpeed = 0x000d;

  /// <summary>
  /// Indicates the reference for giving the direction of GPS receiver movement. "T" denotes true direction and "M" is magnetic direction.
  /// </summary>
  [ExifTagDetails( "GPS Track Reference", "Indicates the reference for giving the direction of GPS receiver movement; 'T' denotes True Direction, 'M' denotes Magnetic Direction" )]
  public const ushort GPSTrackRef = 0x000e;

  /// <summary>
  /// Indicates the direction of GPS receiver movement. The range of values is from 0.00 to 359.99.
  /// </summary>
  [ExifTagDetails( "GPS Track", "Indicates the direction of GPS receiver movement" )]
  public const ushort GPSTrack = 0x000f;

  /// <summary>
  /// Indicates the reference for giving the direction of the image when it is captured. "T" denotes true direction and "M" is magnetic direction.
  /// </summary>
  [ExifTagDetails( "GPS Image Direction Reference", "Indicates the reference for giving the direction of the image when it is captured; 'T' denotes True Direction, 'M' denotes Magnetic Direction" )]
  public const ushort GPSImgDirectionRef = 0x0010;

  /// <summary>
  /// Indicates the direction of the image when it was captured. The range of values is from 0.00 to 359.99.
  /// </summary>
  [ExifTagDetails( "GPS Image Direction", "Indicates the direction of the image when it was captured" )]
  public const ushort GPSImgDirection = 0x0011;

  /// <summary>
  /// Indicates the geodetic survey data used by the GPS receiver. If the survey data is restricted to Japan; the value of this tag is "TOKYO" or "WGS-84".
  /// </summary>
  [ExifTagDetails( "GPS Map Datum", "Indicates the geodetic survey data used by the GPS receiver" )]
  public const ushort GPSMapDatum = 0x0012;

  /// <summary>
  /// Indicates whether the latitude of the destination point is north or south latitude. The ASCII value "N" indicates north latitude; and "S" is south latitude.
  /// </summary>
  [ExifTagDetails( "GPS Destination Latitude Reference", "Indicates whether the latitude of the destination point is North or South latitude; 'N' denotes North latitude, 'S' denotes South latitude" )]
  public const ushort GPSDestLatitudeRef = 0x0013;

  /// <summary>
  /// Indicates the latitude of the destination point. The latitude is expressed as three RATIONAL values giving the degrees; minutes; and seconds; respectively. If latitude is expressed as degrees; minutes and seconds; a typical format would be dd/1;mm/1;ss/1. When degrees and minutes are used and; for example; fractions of minutes are given up to two decimal places; the format would be dd/1;mmmm/100;0/1.
  /// </summary>
  [ExifTagDetails( "GPS Destination Latitude", "Indicates the latitude of the destination point as three Rational values giving the degress, minutes and seconds respectively" )]
  public const ushort GPSDestLatitude = 0x0014;

  /// <summary>
  /// Indicates whether the longitude of the destination point is east or west longitude. ASCII "E" indicates east longitude; and "W" is west longitude.
  /// </summary>
  [ExifTagDetails( "GPS Destination Longitude Reference", "Indicates whether the longitude of the destination point is East or West longitude; 'E' denotes East longitude, 'W' denotes West longitude" )]
  public const ushort GPSDestLongitudeRef = 0x0015;

  /// <summary>
  /// Indicates the longitude of the destination point. The longitude is expressed as three RATIONAL values giving the degrees; minutes; and seconds; respectively. If longitude is expressed as degrees; minutes and seconds; a typical format would be ddd/1;mm/1;ss/1. When degrees and minutes are used and; for example; fractions of minutes are given up to two decimal places; the format would be ddd/1;mmmm/100;0/1.
  /// </summary>
  [ExifTagDetails( "GPS Destination Longitude", "Indicates the longitude of the destination point as three Rational values giving the degress, minutes and seconds respectively" )]
  public const ushort GPSDestLongitude = 0x0016;

  /// <summary>
  /// Indicates the reference used for giving the bearing to the destination point. "T" denotes true direction and "M" is magnetic direction.
  /// </summary>
  [ExifTagDetails( "GPS Destination Bearing Reference", "Indicates the reference used for giving the bearing to the destination point; 'T' denotes true direction and 'M' is magnetic direction" )]
  public const ushort GPSDestBearingRef = 0x0017;

  /// <summary>
  /// Indicates the bearing to the destination point. The range of values is from 0.00 to 359.99.
  /// </summary>
  [ExifTagDetails( "GPS Destination Bearing", "Indicates the bearing to the destination point. The range of values is from 0.00 to 359.99" )]
  public const ushort GPSDestBearing = 0x0018;

  /// <summary>
  /// Indicates the unit used to express the distance to the destination point. "K"; "M" and "N" represent kilometers; miles and knots.
  /// </summary>
  [ExifTagDetails( "GPS Destination Distance Reference", "Indicates the unit used to express the distance to the destination point; 'K', 'M' and 'N' represent kilometers, miles and knots" )]
  public const ushort GPSDestDistanceRef = 0x0019;

  /// <summary>
  /// Indicates the distance to the destination point.
  /// </summary>
  [ExifTagDetails( "GPS Destination Distance", "Indicates the distance to the destination point" )]
  public const ushort GPSDestDistance = 0x001a;

  /// <summary>
  /// A character string recording the name of the method used for location finding. The string encoding is defined using the same scheme as UserComment.
  /// </summary>
  [ExifTagDetails( "GPS Processing Method", "Recording the name of the method used for location finding" )]
  public const ushort GPSProcessingMethod = 0x001b;

  /// <summary>
  /// A character string recording the name of the GPS area. The string encoding is defined using the same scheme as UserComment.
  /// </summary>
  [ExifTagDetails( "GPS Area Information", "Recording the name of the GPS area" )]
  public const ushort GPSAreaInformation = 0x001c;

  /// <summary>
  /// A character string recording date and time information relative to UTC (Coordinated Universal Time). The format is "YYYY:MM:DD.".
  /// </summary>
  [ExifTagDetails( "GPS Date Stamp", "Recording date and time information relative to UTC (Coordinated Universal Time)" )]
  public const ushort GPSDateStamp = 0x001d;

  /// <summary>
  /// Indicates whether differential correction is applied to the GPS receiver.
  /// </summary>
  [ExifTagDetails( "GPS Differential", "Indicates whether differential correction is applied to the GPS receiver" )]
  public const ushort GPSDifferential = 0x001e;

  /// <summary>
  /// This tag indicates horizontal positioning errors in meters
  /// </summary>
  [ExifTagDetails( "GPS Horizontal Positioning Error", "Indicates horizontal positioning errors in meters" )]
  public const ushort GPSHPositioningError = 0x001f;


  //
  // Interoperability Section
  // Added 0x2000 to avoid clash with other tags

  /// <summary>
  /// Indicates the identification of the Interoperability rule. Use "R98" for stating ExifR98 Rules. Four bytes used including the termination code (NULL). see the separate volume of Recommended Exif Interoperability Rules (ExifR98) for other tags used for ExifR98.
  /// </summary>
  [ExifTagDetails( "Interoperability Index", "Indicates the identification of the Interoperability rule; 'R98' denotes ExifR98 Rules" )]
  public const ushort InteroperabilityIndex = 0x0001 + ExifConstants.InteroperabilityOffsetFix;

  /// <summary>
  /// (undefined type) Interoperability version
  /// </summary>
  [ExifTagDetails( "Interoperability Version", "Indicates the Interoperability version" )]
  public const ushort InteroperabilityVersion = 0x0002 + ExifConstants.InteroperabilityOffsetFix;

  /// <summary>
  /// File format of image file
  /// </summary>
  [ExifTagDetails( "Related Image File Format", "File format of image file" )]
  public const ushort RelatedImageFileFormat = 0x1000 + ExifConstants.InteroperabilityOffsetFix;

  /// <summary>
  /// Image width
  /// </summary>
  [ExifTagDetails( "Related Image Width", "Image width" )]
  public const ushort RelatedImageWidth = 0x1001 + ExifConstants.InteroperabilityOffsetFix;

  /// <summary>
  /// Image height
  /// </summary>
  [ExifTagDetails( "Related Image Height", "Image height" )]
  public const ushort RelatedImageLength = 0x1002 + ExifConstants.InteroperabilityOffsetFix;
}