using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum ResponseTypeEnum
{
    [EnumMember(Value = "JSON")]
    Json,

    [EnumMember(Value = "BASE64_GZIP")]
    Base64Gzip
}
