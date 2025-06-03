using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record EmployeesListRequest
{
    /// <summary>
    /// If provided, will only return employees for this company.
    /// </summary>
    [JsonIgnore]
    public string? CompanyId { get; set; }

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
    /// If provided, will only return employees with this display name.
    /// </summary>
    [JsonIgnore]
    public string? DisplayFullName { get; set; }

    /// <summary>
    /// If provided, will only return employees with this employment status.
    ///
    /// * `ACTIVE` - ACTIVE
    /// * `PENDING` - PENDING
    /// * `INACTIVE` - INACTIVE
    /// </summary>
    [JsonIgnore]
    public EmployeesListRequestEmploymentStatus? EmploymentStatus { get; set; }

    /// <summary>
    /// If provided, will only return employees that have an employment of the specified employment_type.
    /// </summary>
    [JsonIgnore]
    public string? EmploymentType { get; set; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<EmployeesListRequestExpandItem> Expand { get; set; } =
        new List<EmployeesListRequestExpandItem>();

    /// <summary>
    /// If provided, will only return employees with this first name.
    /// </summary>
    [JsonIgnore]
    public string? FirstName { get; set; }

    /// <summary>
    /// If provided, will only return employees matching the group ids; multiple groups can be separated by commas.
    /// </summary>
    [JsonIgnore]
    public string? Groups { get; set; }

    /// <summary>
    /// If provided, will only return employees for this home location.
    /// </summary>
    [JsonIgnore]
    public string? HomeLocationId { get; set; }

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
    /// Whether to include sensitive fields (such as social security numbers) in the response.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeSensitiveFields { get; set; }

    /// <summary>
    /// Whether to include shell records. Shell records are empty records (they may contain some metadata but all other fields are null).
    /// </summary>
    [JsonIgnore]
    public bool? IncludeShellData { get; set; }

    /// <summary>
    /// If provided, will only return employees that have an employment of the specified job_title.
    /// </summary>
    [JsonIgnore]
    public string? JobTitle { get; set; }

    /// <summary>
    /// If provided, will only return employees with this last name.
    /// </summary>
    [JsonIgnore]
    public string? LastName { get; set; }

    /// <summary>
    /// If provided, will only return employees for this manager.
    /// </summary>
    [JsonIgnore]
    public string? ManagerId { get; set; }

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
    /// If provided, will only return employees for this pay group
    /// </summary>
    [JsonIgnore]
    public string? PayGroupId { get; set; }

    /// <summary>
    /// If provided, will only return Employees with this personal email
    /// </summary>
    [JsonIgnore]
    public string? PersonalEmail { get; set; }

    /// <summary>
    /// Deprecated. Use show_enum_origins.
    /// </summary>
    [JsonIgnore]
    public EmployeesListRequestRemoteFields? RemoteFields { get; set; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    [JsonIgnore]
    public string? RemoteId { get; set; }

    /// <summary>
    /// A comma separated list of enum field names for which you'd like the original values to be returned, instead of Merge's normalized enum values. [Learn more](https://help.merge.dev/en/articles/8950958-show_enum_origins-query-parameter)
    /// </summary>
    [JsonIgnore]
    public EmployeesListRequestShowEnumOrigins? ShowEnumOrigins { get; set; }

    /// <summary>
    /// If provided, will only return employees that started after this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? StartedAfter { get; set; }

    /// <summary>
    /// If provided, will only return employees that started before this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? StartedBefore { get; set; }

    /// <summary>
    /// If provided, will only return employees for this team.
    /// </summary>
    [JsonIgnore]
    public string? TeamId { get; set; }

    /// <summary>
    /// If provided, will only return employees that were terminated after this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? TerminatedAfter { get; set; }

    /// <summary>
    /// If provided, will only return employees that were terminated before this datetime.
    /// </summary>
    [JsonIgnore]
    public DateTime? TerminatedBefore { get; set; }

    /// <summary>
    /// If provided, will only return Employees with this work email
    /// </summary>
    [JsonIgnore]
    public string? WorkEmail { get; set; }

    /// <summary>
    /// If provided, will only return employees for this location.
    /// </summary>
    [JsonIgnore]
    public string? WorkLocationId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
