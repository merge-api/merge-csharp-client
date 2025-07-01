using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[Serializable]
public record IssuesListRequest
{
    [JsonIgnore]
    public string? AccountToken { get; set; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    [JsonIgnore]
    public string? Cursor { get; set; }

    /// <summary>
    /// If included, will only include issues whose most recent action occurred before this time
    /// </summary>
    [JsonIgnore]
    public string? EndDate { get; set; }

    [JsonIgnore]
    public string? EndUserOrganizationName { get; set; }

    /// <summary>
    /// If provided, will only return issues whose first incident time was after this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? FirstIncidentTimeAfter { get; set; }

    /// <summary>
    /// If provided, will only return issues whose first incident time was before this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? FirstIncidentTimeBefore { get; set; }

    /// <summary>
    /// If true, will include muted issues
    /// </summary>
    [JsonIgnore]
    public string? IncludeMuted { get; set; }

    [JsonIgnore]
    public string? IntegrationName { get; set; }

    /// <summary>
    /// If provided, will only return issues whose last incident time was after this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? LastIncidentTimeAfter { get; set; }

    /// <summary>
    /// If provided, will only return issues whose last incident time was before this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? LastIncidentTimeBefore { get; set; }

    /// <summary>
    /// If provided, will only include issues pertaining to the linked account passed in.
    /// </summary>
    [JsonIgnore]
    public string? LinkedAccountId { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    [JsonIgnore]
    public int? PageSize { get; set; }

    /// <summary>
    /// If included, will only include issues whose most recent action occurred after this time
    /// </summary>
    [JsonIgnore]
    public string? StartDate { get; set; }

    /// <summary>
    /// Status of the issue. Options: ('ONGOING', 'RESOLVED')
    ///
    /// * `ONGOING` - ONGOING
    /// * `RESOLVED` - RESOLVED
    /// </summary>
    [JsonIgnore]
    public IssuesListRequestStatus? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
