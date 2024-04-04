using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
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
