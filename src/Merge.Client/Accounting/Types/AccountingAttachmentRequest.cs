using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public class AccountingAttachmentRequest
{
    /// <summary>
    /// The attachment's name.
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; init; }

    /// <summary>
    /// The attachment's url.
    /// </summary>
    [JsonPropertyName("file_url")]
    public string? FileUrl { get; init; }

    /// <summary>
    /// The company the accounting attachment belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
