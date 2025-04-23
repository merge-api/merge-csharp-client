using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record FieldMappingApiInstanceRemoteField
{
    [JsonPropertyName("remote_key_name")]
    public string? RemoteKeyName { get; set; }

    [JsonPropertyName("schema")]
    public Dictionary<string, object?>? Schema { get; set; }

    [JsonPropertyName("remote_endpoint_info")]
    public required FieldMappingApiInstanceRemoteFieldRemoteEndpointInfo RemoteEndpointInfo { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
