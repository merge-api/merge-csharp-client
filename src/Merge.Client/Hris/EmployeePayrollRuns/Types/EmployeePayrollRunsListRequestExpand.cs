using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum EmployeePayrollRunsListRequestExpand
{
    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "employee,payroll_run")]
    EmployeePayrollRun,

    [EnumMember(Value = "payroll_run")]
    PayrollRun
}
