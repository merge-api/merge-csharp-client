using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum TimeOffListRequestExpand
{
    [EnumMember(Value = "approver")]
    Approver,

    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "employee,approver")]
    EmployeeApprover
}
