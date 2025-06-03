using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(EnumSerializer<GroupsRetrieveRequestExpandItem>))]
public enum GroupsRetrieveRequestExpandItem
{
    [EnumMember(Value = "child_groups")]
    ChildGroups,

    [EnumMember(Value = "users")]
    Users,
}
