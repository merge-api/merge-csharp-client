using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum EmploymentStatusEnum
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "INACTIVE")]
    Inactive
}
