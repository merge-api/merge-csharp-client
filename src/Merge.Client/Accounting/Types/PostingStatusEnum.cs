using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum PostingStatusEnum
{
    [EnumMember(Value = "UNPOSTED")]
    Unposted,

    [EnumMember(Value = "POSTED")]
    Posted
}
