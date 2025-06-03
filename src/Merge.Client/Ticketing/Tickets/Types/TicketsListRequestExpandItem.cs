using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<TicketsListRequestExpandItem>))]
public enum TicketsListRequestExpandItem
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "assigned_teams")]
    AssignedTeams,

    [EnumMember(Value = "assignees")]
    Assignees,

    [EnumMember(Value = "attachments")]
    Attachments,

    [EnumMember(Value = "collections")]
    Collections,

    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "creator")]
    Creator,

    [EnumMember(Value = "parent_ticket")]
    ParentTicket,
}
