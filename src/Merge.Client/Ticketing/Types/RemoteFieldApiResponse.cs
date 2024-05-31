using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("Ticket")]
    public IEnumerable<RemoteFieldApi>? Ticket { get; init; }

    [JsonPropertyName("Comment")]
    public IEnumerable<RemoteFieldApi>? Comment { get; init; }

    [JsonPropertyName("Project")]
    public IEnumerable<RemoteFieldApi>? Project { get; init; }

    [JsonPropertyName("Collection")]
    public IEnumerable<RemoteFieldApi>? Collection { get; init; }

    [JsonPropertyName("User")]
    public IEnumerable<RemoteFieldApi>? User { get; init; }

    [JsonPropertyName("Role")]
    public IEnumerable<RemoteFieldApi>? Role { get; init; }

    [JsonPropertyName("Account")]
    public IEnumerable<RemoteFieldApi>? Account { get; init; }

    [JsonPropertyName("Team")]
    public IEnumerable<RemoteFieldApi>? Team { get; init; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<RemoteFieldApi>? Attachment { get; init; }

    [JsonPropertyName("Tag")]
    public IEnumerable<RemoteFieldApi>? Tag { get; init; }

    [JsonPropertyName("Contact")]
    public IEnumerable<RemoteFieldApi>? Contact { get; init; }
}
