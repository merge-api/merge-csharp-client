using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

/// <summary>
/// # The RemoteData Object
/// ### Description
/// The `RemoteData` object is used to represent the full data pulled from the third-party API for an object.
///
/// ### Usage Example
/// TODO
/// </summary>
[Serializable]
public record RemoteData
{
    /// <summary>
    /// The third-party API path that is being called.
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("data")]
    public object? Data { get; set; }

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
