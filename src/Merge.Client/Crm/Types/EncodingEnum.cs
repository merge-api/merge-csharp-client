using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<EncodingEnum>))]
public enum EncodingEnum
{
    [EnumMember(Value = "RAW")]
    Raw,

    [EnumMember(Value = "BASE64")]
    Base64,

    [EnumMember(Value = "GZIP_BASE64")]
    GzipBase64
}
