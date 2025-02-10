using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record AsyncPassthroughReciept
{
    [JsonPropertyName("async_passthrough_receipt_id")]
    public required string AsyncPassthroughReceiptId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
