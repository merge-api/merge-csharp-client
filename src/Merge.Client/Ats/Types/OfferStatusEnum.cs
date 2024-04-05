using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum OfferStatusEnum
{
    [EnumMember(Value = "DRAFT")]
    Draft,

    [EnumMember(Value = "APPROVAL-SENT")]
    ApprovalSent,

    [EnumMember(Value = "APPROVED")]
    Approved,

    [EnumMember(Value = "SENT")]
    Sent,

    [EnumMember(Value = "SENT-MANUALLY")]
    SentManually,

    [EnumMember(Value = "OPENED")]
    Opened,

    [EnumMember(Value = "DENIED")]
    Denied,

    [EnumMember(Value = "SIGNED")]
    Signed,

    [EnumMember(Value = "DEPRECATED")]
    Deprecated
}
