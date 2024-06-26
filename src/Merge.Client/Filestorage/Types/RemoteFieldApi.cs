using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Filestorage;
using OneOf;

#nullable enable

namespace Merge.Client.Filestorage;

public class RemoteFieldApi
{
    [JsonPropertyName("schema")]
    public Dictionary<string, object> Schema { get; init; }

    [JsonPropertyName("remote_key_name")]
    public string RemoteKeyName { get; init; }

    [JsonPropertyName("remote_endpoint_info")]
    public RemoteEndpointInfo RemoteEndpointInfo { get; init; }

    [JsonPropertyName("example_values")]
    public IEnumerable<object> ExampleValues { get; init; }

    [JsonPropertyName("advanced_metadata")]
    public AdvancedMetadata? AdvancedMetadata { get; init; }

    [JsonPropertyName("coverage")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<int, double>>))]
    public OneOf<int, double>? Coverage { get; init; }
}
