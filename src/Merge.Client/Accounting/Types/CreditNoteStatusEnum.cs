using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum CreditNoteStatusEnum
{
    [EnumMember(Value = "SUBMITTED")]
    Submitted,

    [EnumMember(Value = "AUTHORIZED")]
    Authorized,

    [EnumMember(Value = "PAID")]
    Paid
}
