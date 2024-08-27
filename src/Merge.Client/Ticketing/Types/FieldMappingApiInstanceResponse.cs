using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ticketing;

public record FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Ticket")]
    public IEnumerable<FieldMappingApiInstance>? Ticket { get; set; }

    [JsonPropertyName("Comment")]
    public IEnumerable<FieldMappingApiInstance>? Comment { get; set; }

    [JsonPropertyName("Project")]
    public IEnumerable<FieldMappingApiInstance>? Project { get; set; }

    [JsonPropertyName("Collection")]
    public IEnumerable<FieldMappingApiInstance>? Collection { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<FieldMappingApiInstance>? User { get; set; }

    [JsonPropertyName("Role")]
    public IEnumerable<FieldMappingApiInstance>? Role { get; set; }

    [JsonPropertyName("Account")]
    public IEnumerable<FieldMappingApiInstance>? Account { get; set; }

    [JsonPropertyName("Team")]
    public IEnumerable<FieldMappingApiInstance>? Team { get; set; }

    [JsonPropertyName("Attachment")]
    public IEnumerable<FieldMappingApiInstance>? Attachment { get; set; }

    [JsonPropertyName("Tag")]
    public IEnumerable<FieldMappingApiInstance>? Tag { get; set; }

    [JsonPropertyName("Contact")]
    public IEnumerable<FieldMappingApiInstance>? Contact { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
