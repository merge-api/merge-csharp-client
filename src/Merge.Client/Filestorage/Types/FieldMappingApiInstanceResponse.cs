using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record FieldMappingApiInstanceResponse
{
    [JsonPropertyName("File")]
    public IEnumerable<FieldMappingApiInstance>? File { get; set; }

    [JsonPropertyName("Folder")]
    public IEnumerable<FieldMappingApiInstance>? Folder { get; set; }

    [JsonPropertyName("Drive")]
    public IEnumerable<FieldMappingApiInstance>? Drive { get; set; }

    [JsonPropertyName("Group")]
    public IEnumerable<FieldMappingApiInstance>? Group { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<FieldMappingApiInstance>? User { get; set; }
}
