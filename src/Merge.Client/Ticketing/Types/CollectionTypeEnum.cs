using System.Runtime.Serialization;

namespace Merge.Client.Ticketing;

public enum CollectionTypeEnum
{
    [EnumMember(Value = "LIST")]
    List,

    [EnumMember(Value = "PROJECT")]
    Project
}
