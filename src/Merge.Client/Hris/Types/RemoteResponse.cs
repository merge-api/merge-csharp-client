using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Hris;

/// <summary>
/// # The RemoteResponse Object
/// ### Description
/// The `RemoteResponse` object is used to represent information returned from a third-party endpoint.
///
/// ### Usage Example
/// View the `RemoteResponse` returned from your `DataPassthrough`.
/// </summary>
[Serializable]
public record RemoteResponse
{
    [JsonPropertyName("method")]
    public required string Method { get; set; }

    [JsonPropertyName("path")]
    public required string Path { get; set; }

    [JsonPropertyName("status")]
    public required int Status { get; set; }

    [JsonPropertyName("response")]
    public required object Response { get; set; }

    [JsonPropertyName("response_headers")]
    public Dictionary<string, object?>? ResponseHeaders { get; set; }

    [JsonPropertyName("response_type")]
    public OneOf<ResponseTypeEnum, string>? ResponseType { get; set; }

    [JsonPropertyName("headers")]
    public Dictionary<string, object?>? Headers { get; set; }

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
