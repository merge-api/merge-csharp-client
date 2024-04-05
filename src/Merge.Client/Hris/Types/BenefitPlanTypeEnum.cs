using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum BenefitPlanTypeEnum
{
    [EnumMember(Value = "MEDICAL")]
    Medical,

    [EnumMember(Value = "HEALTH_SAVINGS")]
    HealthSavings,

    [EnumMember(Value = "INSURANCE")]
    Insurance,

    [EnumMember(Value = "RETIREMENT")]
    Retirement,

    [EnumMember(Value = "OTHER")]
    Other
}
