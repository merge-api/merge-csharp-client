using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<BenefitPlanTypeEnum>))]
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
    Other,
}
