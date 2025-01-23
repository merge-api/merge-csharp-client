using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

public record EmployeePayrollRunsListRequest
{
    /// <summary>
    /// If provided, will only return objects created after this datetime.
    /// </summary>
    public DateTime? CreatedAfter { get; set; }

    /// <summary>
    /// If provided, will only return objects created before this datetime.
    /// </summary>
    public DateTime? CreatedBefore { get; set; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// If provided, will only return employee payroll runs for this employee.
    /// </summary>
    public string? EmployeeId { get; set; }

    /// <summary>
    /// If provided, will only return employee payroll runs ended after this datetime.
    /// </summary>
    public DateTime? EndedAfter { get; set; }

    /// <summary>
    /// If provided, will only return employee payroll runs ended before this datetime.
    /// </summary>
    public DateTime? EndedBefore { get; set; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public EmployeePayrollRunsListRequestExpand? Expand { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    public bool? IncludeDeletedData { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include shell records. Shell records are empty records (they may contain some metadata but all other fields are null).
    /// </summary>
    public bool? IncludeShellData { get; set; }

    /// <summary>
    /// If provided, only objects synced by Merge after this date time will be returned.
    /// </summary>
    public DateTime? ModifiedAfter { get; set; }

    /// <summary>
    /// If provided, only objects synced by Merge before this date time will be returned.
    /// </summary>
    public DateTime? ModifiedBefore { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// If provided, will only return employee payroll runs for this employee.
    /// </summary>
    public string? PayrollRunId { get; set; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    public string? RemoteId { get; set; }

    /// <summary>
    /// If provided, will only return employee payroll runs started after this datetime.
    /// </summary>
    public DateTime? StartedAfter { get; set; }

    /// <summary>
    /// If provided, will only return employee payroll runs started before this datetime.
    /// </summary>
    public DateTime? StartedBefore { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
