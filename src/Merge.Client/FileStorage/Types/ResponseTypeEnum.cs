using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(EnumSerializer<ResponseTypeEnum>))]
public enum ResponseTypeEnum
{
    [EnumMember(Value = "JSON")]
    Json,

    [EnumMember(Value = "BASE64_GZIP")]
    Base64Gzip,
}
