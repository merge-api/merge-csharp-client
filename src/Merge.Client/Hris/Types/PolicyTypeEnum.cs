using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
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
