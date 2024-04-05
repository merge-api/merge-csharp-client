using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(TolerantEnumConverter))]
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
