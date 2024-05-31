using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("File")]
    public IEnumerable<FieldMappingApiInstance>? File { get; init; }

    [JsonPropertyName("Folder")]
    public IEnumerable<FieldMappingApiInstance>? Folder { get; init; }

    [JsonPropertyName("Drive")]
    public IEnumerable<FieldMappingApiInstance>? Drive { get; init; }

    [JsonPropertyName("Group")]
    public IEnumerable<FieldMappingApiInstance>? Group { get; init; }

    [JsonPropertyName("User")]
    public IEnumerable<FieldMappingApiInstance>? User { get; init; }
}
