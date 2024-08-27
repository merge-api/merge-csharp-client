using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimeOffListRequestExpand>))]
public enum TimeOffListRequestExpand
{
    [EnumMember(Value = "approver")]
    Approver,

    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "employee,approver")]
    EmployeeApprover,
}
