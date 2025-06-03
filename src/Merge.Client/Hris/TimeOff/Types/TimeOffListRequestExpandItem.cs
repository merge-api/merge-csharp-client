using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<TimeOffListRequestExpandItem>))]
public enum TimeOffListRequestExpandItem
{
    [EnumMember(Value = "approver")]
    Approver,

    [EnumMember(Value = "employee")]
    Employee,
}
