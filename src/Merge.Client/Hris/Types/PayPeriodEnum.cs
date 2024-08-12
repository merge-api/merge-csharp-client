using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<PayPeriodEnum>))]
public enum PayPeriodEnum
{
    [EnumMember(Value = "HOUR")]
    Hour,

    [EnumMember(Value = "DAY")]
    Day,

    [EnumMember(Value = "WEEK")]
    Week,

    [EnumMember(Value = "EVERY_TWO_WEEKS")]
    EveryTwoWeeks,

    [EnumMember(Value = "SEMIMONTHLY")]
    Semimonthly,

    [EnumMember(Value = "MONTH")]
    Month,

    [EnumMember(Value = "QUARTER")]
    Quarter,

    [EnumMember(Value = "EVERY_SIX_MONTHS")]
    EverySixMonths,

    [EnumMember(Value = "YEAR")]
    Year
}
