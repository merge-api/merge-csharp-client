using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("File")]
    public List<ExternalTargetFieldApi>? File { get; init; }

    [JsonPropertyName("Folder")]
    public List<ExternalTargetFieldApi>? Folder { get; init; }

    [JsonPropertyName("Drive")]
    public List<ExternalTargetFieldApi>? Drive { get; init; }

    [JsonPropertyName("Group")]
    public List<ExternalTargetFieldApi>? Group { get; init; }

    [JsonPropertyName("User")]
    public List<ExternalTargetFieldApi>? User { get; init; }
}
