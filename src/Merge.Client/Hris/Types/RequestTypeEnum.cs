using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<RequestTypeEnum>))]
public enum RequestTypeEnum
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
    Bereavement,
}
