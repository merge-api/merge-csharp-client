using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CreditOrDebitEnum>))]
public enum CreditOrDebitEnum
{
    [EnumMember(Value = "CREDIT")]
    Credit,

    [EnumMember(Value = "DEBIT")]
    Debit,
}
