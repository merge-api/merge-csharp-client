using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<CollectionsViewersListRequestExpand>))]
public enum CollectionsViewersListRequestExpand
{
    [EnumMember(Value = "team")]
    Team,

    [EnumMember(Value = "user")]
    User,

    [EnumMember(Value = "user,team")]
    UserTeam,
}
