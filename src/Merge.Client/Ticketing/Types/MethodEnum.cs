using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

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
