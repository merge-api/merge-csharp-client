using System.Text.Json.Serialization;
using Merge.Client.Hris;

namespace Merge.Client.Hris;

public class Dependent
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The dependents's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The dependents's middle name.
    /// </summary>
    [JsonPropertyName("middle_name")]
    public string? MiddleName { get; init; }

    /// <summary>
    /// The dependents's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    /// <summary>
    /// The dependent's relationship to the employee.
    ///
    /// - `CHILD` - CHILD
    /// - `SPOUSE` - SPOUSE
    /// - `DOMESTIC_PARTNER` - DOMESTIC_PARTNER
    /// </summary>
    [JsonPropertyName("relationship")]
    public RelationshipEnum? Relationship { get; init; }

    /// <summary>
    /// The employee this person is a dependent of.
    /// </summary>
    [JsonPropertyName("employee")]
    public string? Employee { get; init; }

    /// <summary>
    /// The dependent's date of birth.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public DateTime? DateOfBirth { get; init; }

    /// <summary>
    /// The dependent's gender.
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
    /// The dependent's phone number.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; init; }

    /// <summary>
    /// The dependents's home address.
    /// </summary>
    [JsonPropertyName("home_location")]
    public string? HomeLocation { get; init; }

    /// <summary>
    /// Whether or not the dependent is a student
    /// </summary>
    [JsonPropertyName("is_student")]
    public bool? IsStudent { get; init; }

    /// <summary>
    /// The dependents's social security number.
    /// </summary>
    [JsonPropertyName("ssn")]
    public string? Ssn { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
