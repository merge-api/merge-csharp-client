using System.Text.Json.Serialization;
using Merge.Client.Hris;
using OneOf;

#nullable enable

namespace Merge.Client.Hris;

public class Employee
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

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
    /// The employee's number that appears in the third-party integration's UI.
    /// </summary>
    [JsonPropertyName("employee_number")]
    public string? EmployeeNumber { get; init; }

    /// <summary>
    /// The ID of the employee's company.
    /// </summary>
    [JsonPropertyName("company")]
    public OneOf<string, Company>? Company { get; init; }

    /// <summary>
    /// The employee's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The employee's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    /// <summary>
    /// The employee's preferred first name.
    /// </summary>
    [JsonPropertyName("preferred_name")]
    public string? PreferredName { get; init; }

    /// <summary>
    /// The employee's full name, to use for display purposes. If a preferred first name is available, the full name will include the preferred first name.
    /// </summary>
    [JsonPropertyName("display_full_name")]
    public string? DisplayFullName { get; init; }

    /// <summary>
    /// The employee's username that appears in the remote UI.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; init; }

    [JsonPropertyName("groups")]
    public List<OneOf<string, Group>?>? Groups { get; init; }

    /// <summary>
    /// The employee's work email.
    /// </summary>
    [JsonPropertyName("work_email")]
    public string? WorkEmail { get; init; }

    /// <summary>
    /// The employee's personal email.
    /// </summary>
    [JsonPropertyName("personal_email")]
    public string? PersonalEmail { get; init; }

    /// <summary>
    /// The employee's mobile phone number.
    /// </summary>
    [JsonPropertyName("mobile_phone_number")]
    public string? MobilePhoneNumber { get; init; }

    /// <summary>
    /// Array of `Employment` IDs for this Employee.
    /// </summary>
    [JsonPropertyName("employments")]
    public List<OneOf<string, Employment>?>? Employments { get; init; }

    /// <summary>
    /// The employee's home address.
    /// </summary>
    [JsonPropertyName("home_location")]
    public OneOf<string, Location>? HomeLocation { get; init; }

    /// <summary>
    /// The employee's work address.
    /// </summary>
    [JsonPropertyName("work_location")]
    public OneOf<string, Location>? WorkLocation { get; init; }

    /// <summary>
    /// The employee ID of the employee's manager.
    /// </summary>
    [JsonPropertyName("manager")]
    public OneOf<string, Employee>? Manager { get; init; }

    /// <summary>
    /// The employee's team.
    /// </summary>
    [JsonPropertyName("team")]
    public OneOf<string, Team>? Team { get; init; }

    /// <summary>
    /// The employee's pay group
    /// </summary>
    [JsonPropertyName("pay_group")]
    public OneOf<string, PayGroup>? PayGroup { get; init; }

    /// <summary>
    /// The employee's social security number.
    /// </summary>
    [JsonPropertyName("ssn")]
    public string? Ssn { get; init; }

    /// <summary>
    /// The employee's gender.
    ///
    /// - `MALE` - MALE
    /// - `FEMALE` - FEMALE
    /// - `NON-BINARY` - NON-BINARY
    /// - `OTHER` - OTHER
    /// - `PREFER_NOT_TO_DISCLOSE` - PREFER_NOT_TO_DISCLOSE
    /// </summary>
    [JsonPropertyName("gender")]
    public GenderEnum? Gender { get; init; }

    /// <summary>
    /// The employee's ethnicity.
    ///
    /// - `AMERICAN_INDIAN_OR_ALASKA_NATIVE` - AMERICAN_INDIAN_OR_ALASKA_NATIVE
    /// - `ASIAN_OR_INDIAN_SUBCONTINENT` - ASIAN_OR_INDIAN_SUBCONTINENT
    /// - `BLACK_OR_AFRICAN_AMERICAN` - BLACK_OR_AFRICAN_AMERICAN
    /// - `HISPANIC_OR_LATINO` - HISPANIC_OR_LATINO
    /// - `NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER` - NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER
    /// - `TWO_OR_MORE_RACES` - TWO_OR_MORE_RACES
    /// - `WHITE` - WHITE
    /// - `PREFER_NOT_TO_DISCLOSE` - PREFER_NOT_TO_DISCLOSE
    /// </summary>
    [JsonPropertyName("ethnicity")]
    public EthnicityEnum? Ethnicity { get; init; }

    /// <summary>
    /// The employee's filing status as related to marital status.
    ///
    /// - `SINGLE` - SINGLE
    /// - `MARRIED_FILING_JOINTLY` - MARRIED_FILING_JOINTLY
    /// - `MARRIED_FILING_SEPARATELY` - MARRIED_FILING_SEPARATELY
    /// - `HEAD_OF_HOUSEHOLD` - HEAD_OF_HOUSEHOLD
    /// - `QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD` - QUALIFYING_WIDOW_OR_WIDOWER_WITH_DEPENDENT_CHILD
    /// </summary>
    [JsonPropertyName("marital_status")]
    public MaritalStatusEnum? MaritalStatus { get; init; }

    /// <summary>
    /// The employee's date of birth.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public DateTime? DateOfBirth { get; init; }

    /// <summary>
    /// The date that the employee was hired, usually the day that an offer letter is signed. If an employee has multiple hire dates from previous employments, this represents the most recent hire date. Note: If you're looking for the employee's start date, refer to the start_date field.
    /// </summary>
    [JsonPropertyName("hire_date")]
    public DateTime? HireDate { get; init; }

    /// <summary>
    /// The date that the employee started working. If an employee was rehired, the most recent start date will be returned.
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateTime? StartDate { get; init; }

    /// <summary>
    /// When the third party's employee was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    /// <summary>
    /// The employment status of the employee.
    ///
    /// - `ACTIVE` - ACTIVE
    /// - `PENDING` - PENDING
    /// - `INACTIVE` - INACTIVE
    /// </summary>
    [JsonPropertyName("employment_status")]
    public EmploymentStatusEnum? EmploymentStatus { get; init; }

    /// <summary>
    /// The employee's termination date.
    /// </summary>
    [JsonPropertyName("termination_date")]
    public DateTime? TerminationDate { get; init; }

    /// <summary>
    /// The URL of the employee's avatar image.
    /// </summary>
    [JsonPropertyName("avatar")]
    public string? Avatar { get; init; }

    /// <summary>
    /// Custom fields configured for a given model.
    /// </summary>
    [JsonPropertyName("custom_fields")]
    public Dictionary<string, object>? CustomFields { get; init; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
