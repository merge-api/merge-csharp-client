using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<RequestFormatEnum>))]
public enum RequestFormatEnum
{
    [EnumMember(Value = "JSON")]
    Json,

    [EnumMember(Value = "XML")]
    Xml,

    [EnumMember(Value = "MULTIPART")]
    Multipart
}
