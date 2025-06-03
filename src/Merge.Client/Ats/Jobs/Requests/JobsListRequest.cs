using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record JobsListRequest
{
    /// <summary>
    /// If provided, will only return jobs with this code.
    /// </summary>
    [JsonIgnore]
    public string? Code { get; set; }

    /// <summary>
    /// If provided, will only return objects created after this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedAfter { get; set; }

    /// <summary>
    /// If provided, will only return objects created before this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedBefore { get; set; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    [JsonIgnore]
    public string? Cursor { get; set; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<JobsListRequestExpandItem> Expand { get; set; } =
        new List<JobsListRequestExpandItem>();

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonIgnore]
    public bool? IncludeDeletedData { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include shell records. Shell records are empty records (they may contain some metadata but all other fields are null).
    /// </summary>
    [JsonIgnore]
    public bool? IncludeShellData { get; set; }

    /// <summary>
    /// If provided, only objects synced by Merge after this date time will be returned.
    /// </summary>
    [JsonIgnore]
    public DateTime? ModifiedAfter { get; set; }

    /// <summary>
    /// If provided, only objects synced by Merge before this date time will be returned.
    /// </summary>
    [JsonIgnore]
    public DateTime? ModifiedBefore { get; set; }

    /// <summary>
    /// If provided, will only return jobs for this office; multiple offices can be separated by commas.
    /// </summary>
    [JsonIgnore]
    public string? Offices { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    [JsonIgnore]
    public int? PageSize { get; set; }

    /// <summary>
    /// Deprecated. Use show_enum_origins.
    /// </summary>
    [JsonIgnore]
    public string? RemoteFields { get; set; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    [JsonIgnore]
    public string? RemoteId { get; set; }

    /// <summary>
    /// A comma separated list of enum field names for which you'd like the original values to be returned, instead of Merge's normalized enum values. [Learn more](https://help.merge.dev/en/articles/8950958-show_enum_origins-query-parameter)
    /// </summary>
    [JsonIgnore]
    public string? ShowEnumOrigins { get; set; }

    /// <summary>
    /// If provided, will only return jobs with this status. Options: ('OPEN', 'CLOSED', 'DRAFT', 'ARCHIVED', 'PENDING')
    ///
    /// * `OPEN` - OPEN
    /// * `CLOSED` - CLOSED
    /// * `DRAFT` - DRAFT
    /// * `ARCHIVED` - ARCHIVED
    /// * `PENDING` - PENDING
    /// </summary>
    [JsonIgnore]
    public JobsListRequestStatus? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
