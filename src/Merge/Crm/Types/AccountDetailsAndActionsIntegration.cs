using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

public record AccountDetailsAndActionsIntegration
{
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("categories")]
    public IEnumerable<CategoriesEnum> Categories { get; set; } = new List<CategoriesEnum>();

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("square_image")]
    public string? SquareImage { get; set; }

    [JsonPropertyName("color")]
    public required string Color { get; set; }

    [JsonPropertyName("slug")]
    public required string Slug { get; set; }

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
