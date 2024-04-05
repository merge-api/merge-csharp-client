using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum RequestFormatEnum
{
    [EnumMember(Value = "JSON")]
    Json,

    [EnumMember(Value = "XML")]
    Xml,

    [EnumMember(Value = "MULTIPART")]
    Multipart
}
