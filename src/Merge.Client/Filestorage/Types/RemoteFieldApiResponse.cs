using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("File")]
    public IEnumerable<RemoteFieldApi>? File { get; init; }

    [JsonPropertyName("Folder")]
    public IEnumerable<RemoteFieldApi>? Folder { get; init; }

    [JsonPropertyName("Drive")]
    public IEnumerable<RemoteFieldApi>? Drive { get; init; }

    [JsonPropertyName("Group")]
    public IEnumerable<RemoteFieldApi>? Group { get; init; }

    [JsonPropertyName("User")]
    public IEnumerable<RemoteFieldApi>? User { get; init; }
}
