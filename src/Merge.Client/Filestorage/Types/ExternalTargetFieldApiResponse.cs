using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("File")]
    public IEnumerable<ExternalTargetFieldApi>? File { get; init; }

    [JsonPropertyName("Folder")]
    public IEnumerable<ExternalTargetFieldApi>? Folder { get; init; }

    [JsonPropertyName("Drive")]
    public IEnumerable<ExternalTargetFieldApi>? Drive { get; init; }

    [JsonPropertyName("Group")]
    public IEnumerable<ExternalTargetFieldApi>? Group { get; init; }

    [JsonPropertyName("User")]
    public IEnumerable<ExternalTargetFieldApi>? User { get; init; }
}
