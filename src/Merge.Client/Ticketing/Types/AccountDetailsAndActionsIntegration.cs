using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

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
}
