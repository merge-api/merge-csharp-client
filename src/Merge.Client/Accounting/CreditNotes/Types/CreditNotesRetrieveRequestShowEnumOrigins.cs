using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum CreditNotesRetrieveRequestShowEnumOrigins
{
    [EnumMember(Value = "status")]
    Status,

    [EnumMember(Value = "status,type")]
    StatusType,

    [EnumMember(Value = "type")]
    Type
}
