using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EmployeePayrollRunsRetrieveRequestExpandItem>))]
public enum EmployeePayrollRunsRetrieveRequestExpandItem
{
    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "payroll_run")]
    PayrollRun,
}
