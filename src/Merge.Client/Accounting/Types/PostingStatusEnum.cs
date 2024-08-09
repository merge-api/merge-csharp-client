using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<PostingStatusEnum>))]
public enum PostingStatusEnum
{
    [EnumMember(Value = "UNPOSTED")]
    Unposted,

    [EnumMember(Value = "POSTED")]
    Posted
}
