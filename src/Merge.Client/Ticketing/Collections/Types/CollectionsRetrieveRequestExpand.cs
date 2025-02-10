using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<CollectionsRetrieveRequestExpand>))]
public enum CollectionsRetrieveRequestExpand
{
    [EnumMember(Value = "parent_collection")]
    ParentCollection,

    [EnumMember(Value = "teams")]
    Teams,

    [EnumMember(Value = "teams,parent_collection")]
    TeamsParentCollection,
}
