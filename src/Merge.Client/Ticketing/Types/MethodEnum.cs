using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum MethodEnum
{
    [EnumMember(Value = "GET")]
    Get,

    [EnumMember(Value = "OPTIONS")]
    Options,

    [EnumMember(Value = "HEAD")]
    Head,

    [EnumMember(Value = "POST")]
    Post,

    [EnumMember(Value = "PUT")]
    Put,

    [EnumMember(Value = "PATCH")]
    Patch,

    [EnumMember(Value = "DELETE")]
    Delete
}
