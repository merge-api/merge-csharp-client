using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public record AccountingPeriod
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

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
    /// Beginning date of the period
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// End date of the period
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; set; }

    [JsonPropertyName("status")]
    public AccountingPeriodStatusEnum? Status { get; set; }

    /// <summary>
    /// Name of the accounting period.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}
