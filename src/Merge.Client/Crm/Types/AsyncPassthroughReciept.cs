using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public class AsyncPassthroughReciept
{
    [JsonPropertyName("async_passthrough_receipt_id")]
    public string AsyncPassthroughReceiptId { get; init; }
}
