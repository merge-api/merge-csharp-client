using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<MethodTypeEnum>))]
public enum MethodTypeEnum
{
    [EnumMember(Value = "CREDIT_CARD")]
    CreditCard,

    [EnumMember(Value = "DEBIT_CARD")]
    DebitCard,

    [EnumMember(Value = "ACH")]
    Ach,

    [EnumMember(Value = "CASH")]
    Cash,

    [EnumMember(Value = "CHECK")]
    Check,
}
