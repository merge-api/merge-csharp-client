using System.Runtime.Serialization;

namespace Merge.Client.Hris;

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
