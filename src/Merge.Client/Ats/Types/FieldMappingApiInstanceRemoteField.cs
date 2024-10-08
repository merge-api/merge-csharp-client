using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record FieldMappingApiInstanceRemoteField
{
    [JsonPropertyName("remote_key_name")]
    public required string RemoteKeyName { get; set; }

    [JsonPropertyName("schema")]
    public Dictionary<string, object?> Schema { get; set; } = new Dictionary<string, object?>();

    [JsonPropertyName("remote_endpoint_info")]
    public required FieldMappingApiInstanceRemoteFieldRemoteEndpointInfo RemoteEndpointInfo { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
