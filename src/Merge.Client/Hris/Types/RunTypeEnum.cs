using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

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
