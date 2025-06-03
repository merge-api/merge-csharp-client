using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public record RemoteFieldApiResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<RemoteFieldApi>? Account { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<RemoteFieldApi>? Contact { get; set; }

    [JsonPropertyName("Lead")]
    public IEnumerable<RemoteFieldApi>? Lead { get; set; }

    [JsonPropertyName("Note")]
    public IEnumerable<RemoteFieldApi>? Note { get; set; }

    [JsonPropertyName("Opportunity")]
    public IEnumerable<RemoteFieldApi>? Opportunity { get; set; }

    [JsonPropertyName("Stage")]
    public IEnumerable<RemoteFieldApi>? Stage { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<RemoteFieldApi>? User { get; set; }

    [JsonPropertyName("Task")]
    public IEnumerable<RemoteFieldApi>? Task { get; set; }

    [JsonPropertyName("Engagement")]
    public IEnumerable<RemoteFieldApi>? Engagement { get; set; }

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
