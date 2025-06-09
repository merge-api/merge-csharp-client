using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

public record LinkToken
{
    [JsonPropertyName("link_token")]
    public required string LinkToken_ { get; set; }

    [JsonPropertyName("integration_name")]
    public string? IntegrationName { get; set; }

    [JsonPropertyName("magic_link_url")]
    public string? MagicLinkUrl { get; set; }

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
