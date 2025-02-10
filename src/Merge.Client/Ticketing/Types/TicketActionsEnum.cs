using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<TicketActionsEnum>))]
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
    Assign,
}
