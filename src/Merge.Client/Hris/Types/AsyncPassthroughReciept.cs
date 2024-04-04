using System.Text.Json.Serialization;

namespace Merge.Client.Hris;

public class AsyncPassthroughReciept
{
    [JsonPropertyName("async_passthrough_receipt_id")]
    public string AsyncPassthroughReceiptId { get; init; }
}
