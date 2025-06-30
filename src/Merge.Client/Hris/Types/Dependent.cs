using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Hris;

/// <summary>
/// # The Dependent Object
/// ### Description
/// The `Dependent` object is used to represent a dependent (e.g. child, spouse, domestic partner, etc) of an `Employee`
///
/// ### Usage Example
/// Fetch from the `LIST Dependents` endpoint and filter by `ID` to show all dependents.
/// </summary>
[Serializable]
public record Dependent
{
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The dependents's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    /// <summary>
    /// The dependents's middle name.
    /// </summary>
    [JsonPropertyName("middle_name")]
    public string? MiddleName { get; set; }

    /// <summary>
    /// The dependents's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// The dependent's relationship to the employee.
    ///
    /// * `CHILD` - CHILD
    /// * `SPOUSE` - SPOUSE
    /// * `DOMESTIC_PARTNER` - DOMESTIC_PARTNER
    /// </summary>
    [JsonPropertyName("relationship")]
    public OneOf<RelationshipEnum, string>? Relationship { get; set; }

    /// <summary>
    /// The employee this person is a dependent of.
    /// </summary>
    [JsonPropertyName("employee")]
    public string? Employee { get; set; }

    /// <summary>
    /// The dependent's date of birth.
    /// </summary>
    [JsonPropertyName("date_of_birth")]
    public DateTime? DateOfBirth { get; set; }

    /// <summary>
    /// The dependent's gender.
    ///
    /// * `MALE` - MALE
    /// * `FEMALE` - FEMALE
    /// * `NON-BINARY` - NON-BINARY
    /// * `OTHER` - OTHER
    /// * `PREFER_NOT_TO_DISCLOSE` - PREFER_NOT_TO_DISCLOSE
    /// </summary>
    [JsonPropertyName("gender")]
    public OneOf<GenderEnum, string>? Gender { get; set; }

    /// <summary>
    /// The dependent's phone number.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// The dependents's home address.
    /// </summary>
    [JsonPropertyName("home_location")]
    public string? HomeLocation { get; set; }

    /// <summary>
    /// Whether or not the dependent is a student
    /// </summary>
    [JsonPropertyName("is_student")]
    public bool? IsStudent { get; set; }

    /// <summary>
    /// The dependents's social security number.
    /// </summary>
    [JsonPropertyName("ssn")]
    public string? Ssn { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
