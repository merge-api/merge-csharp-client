using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<TimeOffListRequestRequestType>))]
public enum TimeOffListRequestRequestType
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
    Volunteer,
}
