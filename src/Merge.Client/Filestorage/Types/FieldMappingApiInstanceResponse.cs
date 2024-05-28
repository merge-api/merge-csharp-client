using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("File")]
    public List<FieldMappingApiInstance>? File { get; init; }

    [JsonPropertyName("Folder")]
    public List<FieldMappingApiInstance>? Folder { get; init; }

    [JsonPropertyName("Drive")]
    public List<FieldMappingApiInstance>? Drive { get; init; }

    [JsonPropertyName("Group")]
    public List<FieldMappingApiInstance>? Group { get; init; }

    [JsonPropertyName("User")]
    public List<FieldMappingApiInstance>? User { get; init; }
}
