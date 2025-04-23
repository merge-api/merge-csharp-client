using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public record FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Account")]
    public IEnumerable<FieldMappingApiInstance>? Account { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<FieldMappingApiInstance>? Contact { get; set; }

    [JsonPropertyName("Lead")]
    public IEnumerable<FieldMappingApiInstance>? Lead { get; set; }

    [JsonPropertyName("Note")]
    public IEnumerable<FieldMappingApiInstance>? Note { get; set; }

    [JsonPropertyName("Opportunity")]
    public IEnumerable<FieldMappingApiInstance>? Opportunity { get; set; }

    [JsonPropertyName("Stage")]
    public IEnumerable<FieldMappingApiInstance>? Stage { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<FieldMappingApiInstance>? User { get; set; }

    [JsonPropertyName("Task")]
    public IEnumerable<FieldMappingApiInstance>? Task { get; set; }

    [JsonPropertyName("Engagement")]
    public IEnumerable<FieldMappingApiInstance>? Engagement { get; set; }

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
