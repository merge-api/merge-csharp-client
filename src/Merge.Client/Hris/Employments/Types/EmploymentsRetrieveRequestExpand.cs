using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum EmploymentsRetrieveRequestExpand
{
    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "employee,pay_group")]
    EmployeePayGroup,

    [EnumMember(Value = "pay_group")]
    PayGroup
}
