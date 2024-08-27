using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

public record ReportItem
{
    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The report item's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The report item's value.
    /// </summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    [JsonPropertyName("sub_items")]
    public IEnumerable<Dictionary<string, object?>>? SubItems { get; set; }

    /// <summary>
    /// The company the report item belongs to.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
