using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<UsersRetrieveRequestExpandItem>))]
public enum UsersRetrieveRequestExpandItem
{
    [EnumMember(Value = "roles")]
    Roles,

    [EnumMember(Value = "teams")]
    Teams,
}
