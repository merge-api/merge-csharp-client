using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
