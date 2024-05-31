using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Accounting;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<CreditNoteStatusEnum>))]
public enum CreditNoteStatusEnum
{
    [EnumMember(Value = "SUBMITTED")]
    Submitted,

    [EnumMember(Value = "AUTHORIZED")]
    Authorized,

    [EnumMember(Value = "PAID")]
    Paid
}
