using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum PolicyTypeEnum
{
    [EnumMember(Value = "VACATION")]
    Vacation,

    [EnumMember(Value = "SICK")]
    Sick,

    [EnumMember(Value = "PERSONAL")]
    Personal,

    [EnumMember(Value = "JURY_DUTY")]
    JuryDuty,

    [EnumMember(Value = "VOLUNTEER")]
    Volunteer,

    [EnumMember(Value = "BEREAVEMENT")]
    Bereavement
}
