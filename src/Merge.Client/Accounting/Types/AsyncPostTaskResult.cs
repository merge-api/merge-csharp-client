using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[Serializable]
public record AsyncPostTaskResult
{
    [JsonPropertyName("status_code")]
    public int? StatusCode { get; set; }

    [JsonPropertyName("response")]
    public Dictionary<string, object?>? Response { get; set; }

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
