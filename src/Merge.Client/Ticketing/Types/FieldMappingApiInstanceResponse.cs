using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Ticket")]
    public IEnumerable<FieldMappingApiInstance>? Ticket { get; init; }

    [JsonPropertyName("Comment")]
    public IEnumerable<FieldMappingApiInstance>? Comment { get; init; }

    [JsonPropertyName("Project")]
    public IEnumerable<FieldMappingApiInstance>? Project { get; init; }

    [JsonPropertyName("Collection")]
    public IEnumerable<FieldMappingApiInstance>? Collection { get; init; }

    [JsonPropertyName("User")]
    public IEnumerable<FieldMappingApiInstance>? User { get; init; }

    [JsonPropertyName("Role")]
    public IEnumerable<FieldMappingApiInstance>? Role { get; init; }

    [JsonPropertyName("Account")]
    public IEnumerable<FieldMappingApiInstance>? Account { get; init; }

    [JsonPropertyName("Team")]
    public IEnumerable<FieldMappingApiInstance>? Team { get; init; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<FieldMappingApiInstance>? Attachment { get; init; }

    [JsonPropertyName("Tag")]
    public IEnumerable<FieldMappingApiInstance>? Tag { get; init; }

    [JsonPropertyName("Contact")]
    public IEnumerable<FieldMappingApiInstance>? Contact { get; init; }
}
