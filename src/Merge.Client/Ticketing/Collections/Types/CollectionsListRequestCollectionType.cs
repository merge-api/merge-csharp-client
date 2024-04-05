using System.Runtime.Serialization;

namespace Merge.Client.Ticketing;

public enum CollectionsListRequestCollectionType
{
    [EnumMember(Value = "LIST")]
    List,

    [EnumMember(Value = "PROJECT")]
    Project
}
