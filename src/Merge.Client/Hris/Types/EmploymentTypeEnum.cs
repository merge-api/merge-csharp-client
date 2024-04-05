using System.Runtime.Serialization;

namespace Merge.Client.Hris;

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
    Freelance
}
