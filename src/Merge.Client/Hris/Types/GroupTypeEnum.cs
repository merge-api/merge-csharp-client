using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<GroupTypeEnum>))]
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
    Group
}
