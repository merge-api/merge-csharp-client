using System.Runtime.Serialization;

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
