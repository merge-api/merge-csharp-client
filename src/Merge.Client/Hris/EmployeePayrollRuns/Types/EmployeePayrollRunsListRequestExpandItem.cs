using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EmployeePayrollRunsListRequestExpandItem>))]
public enum EmployeePayrollRunsListRequestExpandItem
{
    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "payroll_run")]
    PayrollRun,
}
