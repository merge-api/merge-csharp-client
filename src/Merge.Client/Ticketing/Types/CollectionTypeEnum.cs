using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public enum CollectionTypeEnum
{
    [EnumMember(Value = "LIST")]
    List,

    [EnumMember(Value = "PROJECT")]
    Project
}
