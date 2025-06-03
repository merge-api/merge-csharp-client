using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
