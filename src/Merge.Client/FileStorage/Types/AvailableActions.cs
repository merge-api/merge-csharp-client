using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

/// <summary>
/// # The AvailableActions Object
/// ### Description
/// The `Activity` object is used to see all available model/operation combinations for an integration.
///
/// ### Usage Example
/// Fetch all the actions available for the `Zenefits` integration.
/// </summary>
[Serializable]
public record AvailableActions
{
    [JsonPropertyName("integration")]
    public required AccountIntegration Integration { get; set; }

    [JsonPropertyName("passthrough_available")]
    public required bool PassthroughAvailable { get; set; }

    [JsonPropertyName("available_model_operations")]
    public IEnumerable<ModelOperation>? AvailableModelOperations { get; set; }

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
