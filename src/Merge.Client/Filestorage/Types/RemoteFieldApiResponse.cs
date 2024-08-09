using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record RemoteFieldApiResponse
{
    [JsonPropertyName("File")]
    public IEnumerable<RemoteFieldApi>? File { get; set; }

    [JsonPropertyName("Folder")]
    public IEnumerable<RemoteFieldApi>? Folder { get; set; }

    [JsonPropertyName("Drive")]
    public IEnumerable<RemoteFieldApi>? Drive { get; set; }

    [JsonPropertyName("Group")]
    public IEnumerable<RemoteFieldApi>? Group { get; set; }

    [JsonPropertyName("User")]
    public IEnumerable<RemoteFieldApi>? User { get; set; }
}
