using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public record AccountingAttachmentRequest
{
    /// <summary>
    /// The attachment's name.
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; set; }

    /// <summary>
    /// The attachment's url.
    /// </summary>
    [JsonPropertyName("file_url")]
    public string? FileUrl { get; set; }

    /// <summary>
    /// The company the accounting attachment belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }
}
