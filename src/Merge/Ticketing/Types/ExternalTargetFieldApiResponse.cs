using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ticketing;

public record ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Ticket")]
    public IEnumerable<ExternalTargetFieldApi>? Ticket { get; set; }

    [JsonPropertyName("Comment")]
    public IEnumerable<ExternalTargetFieldApi>? Comment { get; set; }

    [JsonPropertyName("Project")]
    public IEnumerable<ExternalTargetFieldApi>? Project { get; set; }

    [JsonPropertyName("Collection")]
    public IEnumerable<ExternalTargetFieldApi>? Collection { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<ExternalTargetFieldApi>? User { get; set; }

    [JsonPropertyName("Role")]
    public IEnumerable<ExternalTargetFieldApi>? Role { get; set; }

    [JsonPropertyName("Account")]
    public IEnumerable<ExternalTargetFieldApi>? Account { get; set; }

    [JsonPropertyName("Team")]
    public IEnumerable<ExternalTargetFieldApi>? Team { get; set; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<ExternalTargetFieldApi>? Attachment { get; set; }

    [JsonPropertyName("Tag")]
    public IEnumerable<ExternalTargetFieldApi>? Tag { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<ExternalTargetFieldApi>? Contact { get; set; }

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
