using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum EmploymentsListRequestExpand
{
    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "employee,pay_group")]
    EmployeePayGroup,

    [EnumMember(Value = "pay_group")]
    PayGroup
}
