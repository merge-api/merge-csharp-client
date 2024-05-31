using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class AvailableActions
{
    [JsonPropertyName("integration")]
    public AccountIntegration Integration { get; init; }

    [JsonPropertyName("passthrough_available")]
    public bool PassthroughAvailable { get; init; }

    [JsonPropertyName("available_model_operations")]
    public IEnumerable<ModelOperation>? AvailableModelOperations { get; init; }
}
