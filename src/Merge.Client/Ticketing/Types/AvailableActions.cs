using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class AvailableActions
{
    [JsonPropertyName("integration")]
    public AccountIntegration Integration { get; init; }

    [JsonPropertyName("passthrough_available")]
    public bool PassthroughAvailable { get; init; }

    [JsonPropertyName("available_model_operations")]
    public List<ModelOperation>? AvailableModelOperations { get; init; }
}
