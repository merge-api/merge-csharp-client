using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum CreditNoteStatusEnum
{
    [EnumMember(Value = "SUBMITTED")]
    Submitted,

    [EnumMember(Value = "AUTHORIZED")]
    Authorized,

    [EnumMember(Value = "PAID")]
    Paid
}
