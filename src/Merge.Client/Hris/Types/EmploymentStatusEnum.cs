using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EmploymentStatusEnum>))]
public enum EmploymentStatusEnum
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "INACTIVE")]
    Inactive,
}
