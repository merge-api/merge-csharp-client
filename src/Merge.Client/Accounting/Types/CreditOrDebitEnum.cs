using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<CreditOrDebitEnum>))]
public enum CreditOrDebitEnum
{
    [EnumMember(Value = "CREDIT")]
    Credit,

    [EnumMember(Value = "DEBIT")]
    Debit,
}
