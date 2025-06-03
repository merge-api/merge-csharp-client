using System.Text.Json.Serialization;
using Merge.Accounting;
using Merge.Core;

namespace Merge.Accounting.Payments;

public record PatchedPaymentEndpointRequest
{
    /// <summary>
    /// Whether to include debug fields (such as log file links) in the response.
    /// </summary>
    [JsonIgnore]
    public bool? IsDebugMode { get; set; }

    /// <summary>
    /// Whether or not third-party updates should be run asynchronously.
    /// </summary>
    [JsonIgnore]
    public bool? RunAsync { get; set; }

    [JsonPropertyName("model")]
    public required PatchedPaymentRequest Model { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
