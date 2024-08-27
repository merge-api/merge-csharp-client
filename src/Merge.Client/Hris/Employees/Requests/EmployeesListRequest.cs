using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

public record EmployeesListRequest
{
    /// <summary>
    /// If provided, will only return employees for this company.
    /// </summary>
    public string? CompanyId { get; set; }

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
    /// If provided, will only return employees with this display name.
    /// </summary>
    public string? DisplayFullName { get; set; }

    /// <summary>
    /// If provided, will only return employees with this employment status.
    ///
    /// - `ACTIVE` - ACTIVE
    /// - `PENDING` - PENDING
    /// - `INACTIVE` - INACTIVE
    /// </summary>
    public EmployeesListRequestEmploymentStatus? EmploymentStatus { get; set; }

    /// <summary>
    /// If provided, will only return employees that have an employment of the specified employment_type.
    /// </summary>
    public string? EmploymentType { get; set; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public EmployeesListRequestExpand? Expand { get; set; }

    /// <summary>
    /// If provided, will only return employees with this first name.
    /// </summary>
    public string? FirstName { get; set; }

    /// <summary>
    /// If provided, will only return employees matching the group ids; multiple groups can be separated by commas.
    /// </summary>
    public string? Groups { get; set; }

    /// <summary>
    /// If provided, will only return employees for this home location.
    /// </summary>
    public string? HomeLocationId { get; set; }

    /// <summary>
    /// Whether to include data that was marked as deleted by third party webhooks.
    /// </summary>
    public bool? IncludeDeletedData { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include sensitive fields (such as social security numbers) in the response.
    /// </summary>
    public bool? IncludeSensitiveFields { get; set; }

    /// <summary>
    /// If provided, will only return employees that have an employment of the specified job_title.
    /// </summary>
    public string? JobTitle { get; set; }

    /// <summary>
    /// If provided, will only return employees with this last name.
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// If provided, will only return employees for this manager.
    /// </summary>
    public string? ManagerId { get; set; }

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
    /// If provided, will only return employees for this pay group
    /// </summary>
    public string? PayGroupId { get; set; }

    /// <summary>
    /// If provided, will only return Employees with this personal email
    /// </summary>
    public string? PersonalEmail { get; set; }

    /// <summary>
    /// Deprecated. Use show_enum_origins.
    /// </summary>
    public EmployeesListRequestRemoteFields? RemoteFields { get; set; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    public string? RemoteId { get; set; }

    /// <summary>
    /// A comma separated list of enum field names for which you'd like the original values to be returned, instead of Merge's normalized enum values. [Learn more](https://help.merge.dev/en/articles/8950958-show_enum_origins-query-parameter)
    /// </summary>
    public EmployeesListRequestShowEnumOrigins? ShowEnumOrigins { get; set; }

    /// <summary>
    /// If provided, will only return employees that started after this datetime.
    /// </summary>
    public DateTime? StartedAfter { get; set; }

    /// <summary>
    /// If provided, will only return employees that started before this datetime.
    /// </summary>
    public DateTime? StartedBefore { get; set; }

    /// <summary>
    /// If provided, will only return employees for this team.
    /// </summary>
    public string? TeamId { get; set; }

    /// <summary>
    /// If provided, will only return employees that were terminated after this datetime.
    /// </summary>
    public DateTime? TerminatedAfter { get; set; }

    /// <summary>
    /// If provided, will only return employees that were terminated before this datetime.
    /// </summary>
    public DateTime? TerminatedBefore { get; set; }

    /// <summary>
    /// If provided, will only return Employees with this work email
    /// </summary>
    public string? WorkEmail { get; set; }

    /// <summary>
    /// If provided, will only return employees for this location.
    /// </summary>
    public string? WorkLocationId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
