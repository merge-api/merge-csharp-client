using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record ExternalTargetFieldApiResponse
{
    [JsonPropertyName("File")]
    public IEnumerable<ExternalTargetFieldApi>? File { get; set; }

    [JsonPropertyName("Folder")]
    public IEnumerable<ExternalTargetFieldApi>? Folder { get; set; }

    [JsonPropertyName("Drive")]
    public IEnumerable<ExternalTargetFieldApi>? Drive { get; set; }

    [JsonPropertyName("Group")]
    public IEnumerable<ExternalTargetFieldApi>? Group { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<ExternalTargetFieldApi>? User { get; set; }
}
