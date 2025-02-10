using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EmploymentTypeEnum>))]
public enum EmploymentTypeEnum
{
    [EnumMember(Value = "FULL_TIME")]
    FullTime,

    [EnumMember(Value = "PART_TIME")]
    PartTime,

    [EnumMember(Value = "INTERN")]
    Intern,

    [EnumMember(Value = "CONTRACTOR")]
    Contractor,

    [EnumMember(Value = "FREELANCE")]
    Freelance,
}
