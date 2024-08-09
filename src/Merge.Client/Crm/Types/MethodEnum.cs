using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<MethodEnum>))]
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
