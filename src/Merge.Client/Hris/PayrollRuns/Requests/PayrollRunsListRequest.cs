using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[Serializable]
public record PayrollRunsListRequest
{
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
    /// If provided, will only return payroll runs ended after this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? EndedAfter { get; set; }

    /// <summary>
    /// If provided, will only return payroll runs ended before this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? EndedBefore { get; set; }

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
    /// Number of results to return per page.
    /// </summary>
    [JsonIgnore]
    public int? PageSize { get; set; }

    /// <summary>
    /// Deprecated. Use show_enum_origins.
    /// </summary>
    [JsonIgnore]
    public PayrollRunsListRequestRemoteFields? RemoteFields { get; set; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    [JsonIgnore]
    public string? RemoteId { get; set; }

    /// <summary>
    /// If provided, will only return PayrollRun's with this status. Options: ('REGULAR', 'OFF_CYCLE', 'CORRECTION', 'TERMINATION', 'SIGN_ON_BONUS')
    ///
    /// * `REGULAR` - REGULAR
    /// * `OFF_CYCLE` - OFF_CYCLE
    /// * `CORRECTION` - CORRECTION
    /// * `TERMINATION` - TERMINATION
    /// * `SIGN_ON_BONUS` - SIGN_ON_BONUS
    /// </summary>
    [JsonIgnore]
    public PayrollRunsListRequestRunType? RunType { get; set; }

    /// <summary>
    /// A comma separated list of enum field names for which you'd like the original values to be returned, instead of Merge's normalized enum values. [Learn more](https://help.merge.dev/en/articles/8950958-show_enum_origins-query-parameter)
    /// </summary>
    [JsonIgnore]
    public PayrollRunsListRequestShowEnumOrigins? ShowEnumOrigins { get; set; }

    /// <summary>
    /// If provided, will only return payroll runs started after this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? StartedAfter { get; set; }

    /// <summary>
    /// If provided, will only return payroll runs started before this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? StartedBefore { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
