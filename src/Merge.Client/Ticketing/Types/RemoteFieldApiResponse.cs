using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ticketing;

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
}
