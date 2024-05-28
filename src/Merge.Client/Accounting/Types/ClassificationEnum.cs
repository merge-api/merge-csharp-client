using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

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
    Revenue
}
