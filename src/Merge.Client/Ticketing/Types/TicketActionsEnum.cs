using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public enum TicketActionsEnum
{
    [EnumMember(Value = "VIEW")]
    View,

    [EnumMember(Value = "CREATE")]
    Create,

    [EnumMember(Value = "EDIT")]
    Edit,

    [EnumMember(Value = "DELETE")]
    Delete,

    [EnumMember(Value = "CLOSE")]
    Close,

    [EnumMember(Value = "ASSIGN")]
    Assign
}
