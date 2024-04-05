using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum ActivityTypeEnum
{
    [EnumMember(Value = "NOTE")]
    Note,

    [EnumMember(Value = "EMAIL")]
    Email,

    [EnumMember(Value = "OTHER")]
    Other
}
