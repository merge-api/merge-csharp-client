using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
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
