using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<TimeOffRetrieveRequestExpandItem>))]
public enum TimeOffRetrieveRequestExpandItem
{
    [EnumMember(Value = "approver")]
    Approver,

    [EnumMember(Value = "employee")]
    Employee,
}
