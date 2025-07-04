using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[Serializable]
public record RemoteFieldApiResponse
{
    [JsonPropertyName("Ticket")]
    public IEnumerable<RemoteFieldApi>? Ticket { get; set; }

    [JsonPropertyName("Comment")]
    public IEnumerable<RemoteFieldApi>? Comment { get; set; }

    [JsonPropertyName("Project")]
    public IEnumerable<RemoteFieldApi>? Project { get; set; }

    [JsonPropertyName("Collection")]
    public IEnumerable<RemoteFieldApi>? Collection { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<RemoteFieldApi>? User { get; set; }

    [JsonPropertyName("Role")]
    public IEnumerable<RemoteFieldApi>? Role { get; set; }

    [JsonPropertyName("Account")]
    public IEnumerable<RemoteFieldApi>? Account { get; set; }

    [JsonPropertyName("Team")]
    public IEnumerable<RemoteFieldApi>? Team { get; set; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<RemoteFieldApi>? Attachment { get; set; }

    [JsonPropertyName("Tag")]
    public IEnumerable<RemoteFieldApi>? Tag { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<RemoteFieldApi>? Contact { get; set; }

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
