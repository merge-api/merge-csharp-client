using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

namespace Merge.Client.Filestorage;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("File")]
    public List<RemoteFieldApi>? File { get; init; }

    [JsonPropertyName("Folder")]
    public List<RemoteFieldApi>? Folder { get; init; }

    [JsonPropertyName("Drive")]
    public List<RemoteFieldApi>? Drive { get; init; }

    [JsonPropertyName("Group")]
    public List<RemoteFieldApi>? Group { get; init; }

    [JsonPropertyName("User")]
    public List<RemoteFieldApi>? User { get; init; }
}
