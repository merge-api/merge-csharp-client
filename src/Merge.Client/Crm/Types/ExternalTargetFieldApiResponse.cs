using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[Serializable]
public record ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<ExternalTargetFieldApi>? Account { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<ExternalTargetFieldApi>? Contact { get; set; }

    [JsonPropertyName("Lead")]
    public IEnumerable<ExternalTargetFieldApi>? Lead { get; set; }

    [JsonPropertyName("Note")]
    public IEnumerable<ExternalTargetFieldApi>? Note { get; set; }

    [JsonPropertyName("Opportunity")]
    public IEnumerable<ExternalTargetFieldApi>? Opportunity { get; set; }

    [JsonPropertyName("Stage")]
    public IEnumerable<ExternalTargetFieldApi>? Stage { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<ExternalTargetFieldApi>? User { get; set; }

    [JsonPropertyName("Task")]
    public IEnumerable<ExternalTargetFieldApi>? Task { get; set; }

    [JsonPropertyName("Engagement")]
    public IEnumerable<ExternalTargetFieldApi>? Engagement { get; set; }

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
