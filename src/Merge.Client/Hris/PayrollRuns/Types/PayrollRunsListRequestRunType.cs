using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum PayrollRunsListRequestRunType
{
    [EnumMember(Value = "CORRECTION")]
    Correction,

    [EnumMember(Value = "OFF_CYCLE")]
    OffCycle,

    [EnumMember(Value = "REGULAR")]
    Regular,

    [EnumMember(Value = "SIGN_ON_BONUS")]
    SignOnBonus,

    [EnumMember(Value = "TERMINATION")]
    Termination
}
