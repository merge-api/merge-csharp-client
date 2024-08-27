using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<RunTypeEnum>))]
public enum RunTypeEnum
{
    [EnumMember(Value = "REGULAR")]
    Regular,

    [EnumMember(Value = "OFF_CYCLE")]
    OffCycle,

    [EnumMember(Value = "CORRECTION")]
    Correction,

    [EnumMember(Value = "TERMINATION")]
    Termination,

    [EnumMember(Value = "SIGN_ON_BONUS")]
    SignOnBonus,
}
