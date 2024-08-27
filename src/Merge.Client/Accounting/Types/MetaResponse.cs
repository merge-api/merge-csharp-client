using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

public record MetaResponse
{
    [JsonPropertyName("request_schema")]
    public Dictionary<string, object?> RequestSchema { get; set; } =
        new Dictionary<string, object?>();

    [JsonPropertyName("remote_field_classes")]
    public Dictionary<string, object?>? RemoteFieldClasses { get; set; }

    [JsonPropertyName("status")]
    public LinkedAccountStatus? Status { get; set; }

    [JsonPropertyName("has_conditional_params")]
    public required bool HasConditionalParams { get; set; }

    [JsonPropertyName("has_required_linked_account_params")]
    public required bool HasRequiredLinkedAccountParams { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
