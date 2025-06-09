using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(EnumSerializer<GroupsListRequestExpandItem>))]
public enum GroupsListRequestExpandItem
{
    [EnumMember(Value = "child_groups")]
    ChildGroups,

    [EnumMember(Value = "users")]
    Users,
}
