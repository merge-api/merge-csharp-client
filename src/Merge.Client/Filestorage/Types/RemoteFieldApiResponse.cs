using System.Text.Json.Serialization;
using Merge.Client.Core;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
