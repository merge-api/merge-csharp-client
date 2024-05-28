using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

public class ModelOperation
{
    [JsonPropertyName("model_name")]
    public string ModelName { get; init; }

    [JsonPropertyName("available_operations")]
    public List<string> AvailableOperations { get; init; }

    [JsonPropertyName("required_post_parameters")]
    public List<string> RequiredPostParameters { get; init; }

    [JsonPropertyName("supported_fields")]
    public List<string> SupportedFields { get; init; }
}
