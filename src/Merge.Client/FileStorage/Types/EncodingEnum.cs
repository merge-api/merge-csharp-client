using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(EnumSerializer<EncodingEnum>))]
public enum EncodingEnum
{
    [EnumMember(Value = "RAW")]
    Raw,

    [EnumMember(Value = "BASE64")]
    Base64,

    [EnumMember(Value = "GZIP_BASE64")]
    GzipBase64,
}
