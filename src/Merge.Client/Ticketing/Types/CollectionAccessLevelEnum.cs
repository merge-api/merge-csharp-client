using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<CollectionAccessLevelEnum>))]
public enum CollectionAccessLevelEnum
{
    [EnumMember(Value = "PRIVATE")]
    Private,

    [EnumMember(Value = "COMPANY")]
    Company,

    [EnumMember(Value = "PUBLIC")]
    Public,

    [EnumMember(Value = "PARENT_COLLECTION")]
    ParentCollection,
}
