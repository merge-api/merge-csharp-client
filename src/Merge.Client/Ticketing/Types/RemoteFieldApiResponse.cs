using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("Ticket")]
    public List<RemoteFieldApi>? Ticket { get; init; }

    [JsonPropertyName("Comment")]
    public List<RemoteFieldApi>? Comment { get; init; }

    [JsonPropertyName("Project")]
    public List<RemoteFieldApi>? Project { get; init; }

    [JsonPropertyName("Collection")]
    public List<RemoteFieldApi>? Collection { get; init; }

    [JsonPropertyName("User")]
    public List<RemoteFieldApi>? User { get; init; }

    [JsonPropertyName("Role")]
    public List<RemoteFieldApi>? Role { get; init; }

    [JsonPropertyName("Account")]
    public List<RemoteFieldApi>? Account { get; init; }

    [JsonPropertyName("Team")]
    public List<RemoteFieldApi>? Team { get; init; }

    [JsonPropertyName("Attachment")]
    public List<RemoteFieldApi>? Attachment { get; init; }

    [JsonPropertyName("Tag")]
    public List<RemoteFieldApi>? Tag { get; init; }

    [JsonPropertyName("Contact")]
    public List<RemoteFieldApi>? Contact { get; init; }
}
