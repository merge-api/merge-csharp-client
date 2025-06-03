using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<CommentsListRequestExpandItem>))]
public enum CommentsListRequestExpandItem
{
    [EnumMember(Value = "contact")]
    Contact,

    [EnumMember(Value = "ticket")]
    Ticket,

    [EnumMember(Value = "user")]
    User,
}
