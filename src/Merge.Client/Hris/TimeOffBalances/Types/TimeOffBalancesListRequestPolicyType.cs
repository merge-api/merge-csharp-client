using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum TimeOffBalancesListRequestPolicyType
{
    [EnumMember(Value = "BEREAVEMENT")]
    Bereavement,

    [EnumMember(Value = "JURY_DUTY")]
    JuryDuty,

    [EnumMember(Value = "PERSONAL")]
    Personal,

    [EnumMember(Value = "SICK")]
    Sick,

    [EnumMember(Value = "VACATION")]
    Vacation,

    [EnumMember(Value = "VOLUNTEER")]
    Volunteer
}
