using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<ClassificationEnum>))]
public enum ClassificationEnum
{
    [EnumMember(Value = "ASSET")]
    Asset,

    [EnumMember(Value = "EQUITY")]
    Equity,

    [EnumMember(Value = "EXPENSE")]
    Expense,

    [EnumMember(Value = "LIABILITY")]
    Liability,

    [EnumMember(Value = "REVENUE")]
    Revenue,
}
