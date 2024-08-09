using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayrollRunsListRequestRunType>))]
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
