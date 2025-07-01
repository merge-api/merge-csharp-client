using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

/// <summary>
/// # The ModelOperation Object
/// ### Description
/// The `ModelOperation` object is used to represent the operations that are currently supported for a given model.
///
/// ### Usage Example
/// View what operations are supported for the `Candidate` endpoint.
/// </summary>
[Serializable]
public record ModelOperation
{
    [JsonPropertyName("model_name")]
    public required string ModelName { get; set; }

    [JsonPropertyName("available_operations")]
    public IEnumerable<string> AvailableOperations { get; set; } = new List<string>();

    [JsonPropertyName("required_post_parameters")]
    public IEnumerable<string> RequiredPostParameters { get; set; } = new List<string>();

    [JsonPropertyName("supported_fields")]
    public IEnumerable<string> SupportedFields { get; set; } = new List<string>();

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
