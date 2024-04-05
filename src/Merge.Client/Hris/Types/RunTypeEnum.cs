using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
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
    SignOnBonus
}
