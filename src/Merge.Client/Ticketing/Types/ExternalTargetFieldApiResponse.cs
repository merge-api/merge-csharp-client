using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Ticket")]
    public List<ExternalTargetFieldApi>? Ticket { get; init; }

    [JsonPropertyName("Comment")]
    public List<ExternalTargetFieldApi>? Comment { get; init; }

    [JsonPropertyName("Project")]
    public List<ExternalTargetFieldApi>? Project { get; init; }

    [JsonPropertyName("Collection")]
    public List<ExternalTargetFieldApi>? Collection { get; init; }

    [JsonPropertyName("User")]
    public List<ExternalTargetFieldApi>? User { get; init; }

    [JsonPropertyName("Role")]
    public List<ExternalTargetFieldApi>? Role { get; init; }

    [JsonPropertyName("Account")]
    public List<ExternalTargetFieldApi>? Account { get; init; }

    [JsonPropertyName("Team")]
    public List<ExternalTargetFieldApi>? Team { get; init; }

    [JsonPropertyName("Attachment")]
    public List<ExternalTargetFieldApi>? Attachment { get; init; }

    [JsonPropertyName("Tag")]
    public List<ExternalTargetFieldApi>? Tag { get; init; }

    [JsonPropertyName("Contact")]
    public List<ExternalTargetFieldApi>? Contact { get; init; }
}
