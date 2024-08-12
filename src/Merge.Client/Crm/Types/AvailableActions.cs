using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record AvailableActions
{
    [JsonPropertyName("integration")]
    public required AccountIntegration Integration { get; set; }

    [JsonPropertyName("passthrough_available")]
    public required bool PassthroughAvailable { get; set; }

    [JsonPropertyName("available_model_operations")]
    public IEnumerable<ModelOperation>? AvailableModelOperations { get; set; }
}
