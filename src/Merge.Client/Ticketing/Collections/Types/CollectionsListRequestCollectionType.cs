using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum CollectionsListRequestCollectionType
{
    [EnumMember(Value = "LIST")]
    List,

    [EnumMember(Value = "PROJECT")]
    Project
}
