using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Hris;

public record LinkedAccountStatus
{
    [JsonPropertyName("linked_account_status")]
    public required string LinkedAccountStatus_ { get; set; }

    [JsonPropertyName("can_make_request")]
    public required bool CanMakeRequest { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
