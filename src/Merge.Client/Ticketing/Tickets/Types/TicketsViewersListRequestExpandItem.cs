using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<TicketsViewersListRequestExpandItem>))]
public enum TicketsViewersListRequestExpandItem
{
    [EnumMember(Value = "team")]
    Team,

    [EnumMember(Value = "user")]
    User,
}
