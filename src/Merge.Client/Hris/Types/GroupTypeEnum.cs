using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<GroupTypeEnum>))]
public enum GroupTypeEnum
{
    [EnumMember(Value = "TEAM")]
    Team,

    [EnumMember(Value = "DEPARTMENT")]
    Department,

    [EnumMember(Value = "COST_CENTER")]
    CostCenter,

    [EnumMember(Value = "BUSINESS_UNIT")]
    BusinessUnit,

    [EnumMember(Value = "GROUP")]
    Group,
}
