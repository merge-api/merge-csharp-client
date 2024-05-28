using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum CreditNotesListRequestRemoteFields
{
    [EnumMember(Value = "status")]
    Status,

    [EnumMember(Value = "status,type")]
    StatusType,

    [EnumMember(Value = "type")]
    Type
}
