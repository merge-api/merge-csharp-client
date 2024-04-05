using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum EncodingEnum
{
    [EnumMember(Value = "RAW")]
    Raw,

    [EnumMember(Value = "BASE64")]
    Base64,

    [EnumMember(Value = "GZIP_BASE64")]
    GzipBase64
}
