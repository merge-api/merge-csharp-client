using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class AvailableActions
{
    [JsonPropertyName("integration")]
    public AccountIntegration Integration { get; init; }

    [JsonPropertyName("passthrough_available")]
    public bool PassthroughAvailable { get; init; }

    [JsonPropertyName("available_model_operations")]
    public IEnumerable<ModelOperation>? AvailableModelOperations { get; init; }
}
