using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats;

public record MetaResponse
{
    [JsonPropertyName("request_schema")]
    public object RequestSchema { get; set; } = new Dictionary<string, object?>();

    [JsonPropertyName("remote_field_classes")]
    public object? RemoteFieldClasses { get; set; }

    [JsonPropertyName("status")]
    public LinkedAccountStatus? Status { get; set; }

    [JsonPropertyName("has_conditional_params")]
    public required bool HasConditionalParams { get; set; }

    [JsonPropertyName("has_required_linked_account_params")]
    public required bool HasRequiredLinkedAccountParams { get; set; }

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
