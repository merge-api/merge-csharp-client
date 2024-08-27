using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ClassificationEnum>))]
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
