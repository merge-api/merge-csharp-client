using System.Text.Json.Serialization;

namespace Merge.Client.Accounting;

public class ReportItem
{
    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The report item's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The report item's value.
    /// </summary>
    [JsonPropertyName("value")]
    public double? Value { get; init; }

    [JsonPropertyName("sub_items")]
    public List<Dictionary<string, object>>? SubItems { get; init; }

    /// <summary>
    /// The company the report item belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }
}
