using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum EncodingEnum
{
    [EnumMember(Value = "RAW")]
    Raw,

    [EnumMember(Value = "BASE64")]
    Base64,

    [EnumMember(Value = "GZIP_BASE64")]
    GzipBase64
}
