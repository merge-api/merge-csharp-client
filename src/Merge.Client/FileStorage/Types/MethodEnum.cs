using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(EnumSerializer<MethodEnum>))]
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
    Delete,
}
