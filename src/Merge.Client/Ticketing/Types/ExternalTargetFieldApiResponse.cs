using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Ticket")]
    public IEnumerable<ExternalTargetFieldApi>? Ticket { get; init; }

    [JsonPropertyName("Comment")]
    public IEnumerable<ExternalTargetFieldApi>? Comment { get; init; }

    [JsonPropertyName("Project")]
    public IEnumerable<ExternalTargetFieldApi>? Project { get; init; }

    [JsonPropertyName("Collection")]
    public IEnumerable<ExternalTargetFieldApi>? Collection { get; init; }

    [JsonPropertyName("User")]
    public IEnumerable<ExternalTargetFieldApi>? User { get; init; }

    [JsonPropertyName("Role")]
    public IEnumerable<ExternalTargetFieldApi>? Role { get; init; }

    [JsonPropertyName("Account")]
    public IEnumerable<ExternalTargetFieldApi>? Account { get; init; }

    [JsonPropertyName("Team")]
    public IEnumerable<ExternalTargetFieldApi>? Team { get; init; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<ExternalTargetFieldApi>? Attachment { get; init; }

    [JsonPropertyName("Tag")]
    public IEnumerable<ExternalTargetFieldApi>? Tag { get; init; }

    [JsonPropertyName("Contact")]
    public IEnumerable<ExternalTargetFieldApi>? Contact { get; init; }
}
