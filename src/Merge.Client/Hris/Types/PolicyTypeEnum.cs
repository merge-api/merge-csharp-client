using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PolicyTypeEnum>))]
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
