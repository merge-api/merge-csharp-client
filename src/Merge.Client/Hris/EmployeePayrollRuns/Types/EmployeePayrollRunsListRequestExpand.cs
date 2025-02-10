using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EmployeePayrollRunsListRequestExpand>))]
public enum EmployeePayrollRunsListRequestExpand
{
    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "employee,payroll_run")]
    EmployeePayrollRun,

    [EnumMember(Value = "payroll_run")]
    PayrollRun,
}
