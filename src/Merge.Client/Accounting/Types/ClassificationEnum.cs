using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
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
