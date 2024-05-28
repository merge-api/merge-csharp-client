using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class MetaResponse
{
    [JsonPropertyName("request_schema")]
    public Dictionary<string, object> RequestSchema { get; init; }

    [JsonPropertyName("remote_field_classes")]
    public Dictionary<string, object>? RemoteFieldClasses { get; init; }

    [JsonPropertyName("status")]
    public LinkedAccountStatus? Status { get; init; }

    [JsonPropertyName("has_conditional_params")]
    public bool HasConditionalParams { get; init; }

    [JsonPropertyName("has_required_linked_account_params")]
    public bool HasRequiredLinkedAccountParams { get; init; }
}
