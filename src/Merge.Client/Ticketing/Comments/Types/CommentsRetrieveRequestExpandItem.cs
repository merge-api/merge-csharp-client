using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<CommentsRetrieveRequestExpandItem>))]
public enum CommentsRetrieveRequestExpandItem
{
    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "ticket")]
    Ticket,

    [EnumMember(Value = "user")]
    User,
}
