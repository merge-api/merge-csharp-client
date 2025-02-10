using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<CreditNoteStatusEnum>))]
public enum CreditNoteStatusEnum
{
    [EnumMember(Value = "SUBMITTED")]
    Submitted,

    [EnumMember(Value = "AUTHORIZED")]
    Authorized,

    [EnumMember(Value = "PAID")]
    Paid,
}
