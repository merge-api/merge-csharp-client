using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<PostingStatusEnum>))]
public enum PostingStatusEnum
{
    [EnumMember(Value = "UNPOSTED")]
    Unposted,

    [EnumMember(Value = "POSTED")]
    Posted,
}
