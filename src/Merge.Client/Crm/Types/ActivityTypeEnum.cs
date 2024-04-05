using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Crm;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum ActivityTypeEnum
{
    [EnumMember(Value = "CALL")]
    Call,

    [EnumMember(Value = "MEETING")]
    Meeting,

    [EnumMember(Value = "EMAIL")]
    Email
}
