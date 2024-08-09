using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record AsyncPassthroughReciept
{
    [JsonPropertyName("async_passthrough_receipt_id")]
    public required string AsyncPassthroughReceiptId { get; set; }
}
