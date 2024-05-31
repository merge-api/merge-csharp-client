using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public class ModelOperation
{
    [JsonPropertyName("model_name")]
    public string ModelName { get; init; }

    [JsonPropertyName("available_operations")]
    public IEnumerable<string> AvailableOperations { get; init; }

    [JsonPropertyName("required_post_parameters")]
    public IEnumerable<string> RequiredPostParameters { get; init; }

    [JsonPropertyName("supported_fields")]
    public IEnumerable<string> SupportedFields { get; init; }
}
