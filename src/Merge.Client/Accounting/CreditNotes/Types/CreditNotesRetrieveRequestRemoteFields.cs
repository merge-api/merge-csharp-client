using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum CreditNotesRetrieveRequestRemoteFields
{
    [EnumMember(Value = "status")]
    Status,

    [EnumMember(Value = "status,type")]
    StatusType,

    [EnumMember(Value = "type")]
    Type
}
