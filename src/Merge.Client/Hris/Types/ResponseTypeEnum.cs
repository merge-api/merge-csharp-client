using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum ResponseTypeEnum
{
    [EnumMember(Value = "JSON")]
    Json,

    [EnumMember(Value = "BASE64_GZIP")]
    Base64Gzip
}
