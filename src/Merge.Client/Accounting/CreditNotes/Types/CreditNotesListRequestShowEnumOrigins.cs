using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum CreditNotesListRequestShowEnumOrigins
{
    [EnumMember(Value = "status")]
    Status,

    [EnumMember(Value = "status,type")]
    StatusType,

    [EnumMember(Value = "type")]
    Type
}
