using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum EmployeesListRequestEmploymentStatus
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "INACTIVE")]
    Inactive,

    [EnumMember(Value = "PENDING")]
    Pending
}
