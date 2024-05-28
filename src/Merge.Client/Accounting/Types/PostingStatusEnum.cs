using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum PostingStatusEnum
{
    [EnumMember(Value = "UNPOSTED")]
    Unposted,

    [EnumMember(Value = "POSTED")]
    Posted
}
