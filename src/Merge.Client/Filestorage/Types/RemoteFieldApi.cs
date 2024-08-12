using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Filestorage;

public record RemoteFieldApi
{
    [JsonPropertyName("schema")]
    public Dictionary<string, object?> Schema { get; set; } = new Dictionary<string, object?>();

    [JsonPropertyName("remote_key_name")]
    public required string RemoteKeyName { get; set; }

    [JsonPropertyName("remote_endpoint_info")]
    public required RemoteEndpointInfo RemoteEndpointInfo { get; set; }

    [JsonPropertyName("example_values")]
    public IEnumerable<object>? ExampleValues { get; set; }

    [JsonPropertyName("advanced_metadata")]
    public AdvancedMetadata? AdvancedMetadata { get; set; }

    [JsonPropertyName("coverage")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<int, double>>))]
    public OneOf<int, double>? Coverage { get; set; }
}
