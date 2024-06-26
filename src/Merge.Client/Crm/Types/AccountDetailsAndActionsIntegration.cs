using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class AccountDetailsAndActionsIntegration
{
    [JsonPropertyName("name")]
    public string Name { get; init; }

    [JsonPropertyName("categories")]
    public IEnumerable<CategoriesEnum> Categories { get; init; }

    [JsonPropertyName("image")]
    public string? Image { get; init; }

    [JsonPropertyName("square_image")]
    public string? SquareImage { get; init; }

    [JsonPropertyName("color")]
    public string Color { get; init; }

    [JsonPropertyName("slug")]
    public string Slug { get; init; }

    [JsonPropertyName("passthrough_available")]
    public bool PassthroughAvailable { get; init; }

    [JsonPropertyName("available_model_operations")]
    public IEnumerable<ModelOperation>? AvailableModelOperations { get; init; }
}
