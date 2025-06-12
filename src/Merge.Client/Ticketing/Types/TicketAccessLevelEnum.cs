using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<TicketAccessLevelEnum>))]
public enum TicketAccessLevelEnum
{
    [EnumMember(Value = "COMPANY")]
    Company,

    [EnumMember(Value = "PUBLIC")]
    Public,

    [EnumMember(Value = "PRIVATE")]
    Private,

    [EnumMember(Value = "COLLECTION")]
    Collection,
}
