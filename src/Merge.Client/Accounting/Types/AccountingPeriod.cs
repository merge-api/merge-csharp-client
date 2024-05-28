using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class AccountingPeriod
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// Beginning date of the period
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; init; }

    /// <summary>
    /// End date of the period
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateTime? EndDate { get; init; }

    [JsonPropertyName("status")]
    public AccountingPeriodStatusEnum? Status { get; init; }

    /// <summary>
    /// Name of the accounting period.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
