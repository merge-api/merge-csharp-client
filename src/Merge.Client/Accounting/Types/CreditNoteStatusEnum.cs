using System.Runtime.Serialization;

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
