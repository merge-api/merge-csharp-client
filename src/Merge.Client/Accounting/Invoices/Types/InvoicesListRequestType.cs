using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<InvoicesListRequestType>))]
public enum InvoicesListRequestType
{
    [EnumMember(Value = "ACCOUNTS_PAYABLE")]
    AccountsPayable,

    [EnumMember(Value = "ACCOUNTS_RECEIVABLE")]
    AccountsReceivable
}
