using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum EmployeePayrollRunsRetrieveRequestExpand
{
    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "employee,payroll_run")]
    EmployeePayrollRun,

    [EnumMember(Value = "payroll_run")]
    PayrollRun
}
