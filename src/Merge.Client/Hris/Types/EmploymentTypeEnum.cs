using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
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
