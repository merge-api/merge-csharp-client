using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<CollectionsListRequestExpand>))]
public enum CollectionsListRequestExpand
{
    [EnumMember(Value = "parent_collection")]
    ParentCollection,

    [EnumMember(Value = "teams")]
    Teams,

    [EnumMember(Value = "teams,parent_collection")]
    TeamsParentCollection,
}
