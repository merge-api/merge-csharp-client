using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Ticket")]
    public List<FieldMappingApiInstance>? Ticket { get; init; }

    [JsonPropertyName("Comment")]
    public List<FieldMappingApiInstance>? Comment { get; init; }

    [JsonPropertyName("Project")]
    public List<FieldMappingApiInstance>? Project { get; init; }

    [JsonPropertyName("Collection")]
    public List<FieldMappingApiInstance>? Collection { get; init; }

    [JsonPropertyName("User")]
    public List<FieldMappingApiInstance>? User { get; init; }

    [JsonPropertyName("Role")]
    public List<FieldMappingApiInstance>? Role { get; init; }

    [JsonPropertyName("Account")]
    public List<FieldMappingApiInstance>? Account { get; init; }

    [JsonPropertyName("Team")]
    public List<FieldMappingApiInstance>? Team { get; init; }

    [JsonPropertyName("Attachment")]
    public List<FieldMappingApiInstance>? Attachment { get; init; }

    [JsonPropertyName("Tag")]
    public List<FieldMappingApiInstance>? Tag { get; init; }

    [JsonPropertyName("Contact")]
    public List<FieldMappingApiInstance>? Contact { get; init; }
}
