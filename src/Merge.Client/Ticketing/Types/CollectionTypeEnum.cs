using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(EnumSerializer<CollectionTypeEnum>))]
public enum CollectionTypeEnum
{
    [EnumMember(Value = "LIST")]
    List,

    [EnumMember(Value = "PROJECT")]
    Project,
}
