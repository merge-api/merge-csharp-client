using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EmploymentsRetrieveRequestExpandItem>))]
public enum EmploymentsRetrieveRequestExpandItem
{
    [EnumMember(Value = "employee")]
    Employee,

    [EnumMember(Value = "pay_group")]
    PayGroup,
}
