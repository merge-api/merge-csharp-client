using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
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
