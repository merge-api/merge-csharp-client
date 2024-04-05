using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum PostingStatusEnum
{
    [EnumMember(Value = "UNPOSTED")]
    Unposted,

    [EnumMember(Value = "POSTED")]
    Posted
}
