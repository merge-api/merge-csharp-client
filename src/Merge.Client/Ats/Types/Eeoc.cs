using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ats;

/// <summary>
/// # The EEOC Object
/// ### Description
/// The `EEOC` object is used to represent the Equal Employment Opportunity Commission information for a candidate (race, gender, veteran status, disability status).
/// ### Usage Example
/// Fetch from the `LIST EEOCs` endpoint and filter by `candidate` to show all EEOC information for a candidate.
/// </summary>
public record Eeoc
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
    /// The candidate being represented.
    /// </summary>
    [JsonPropertyName("candidate")]
    public OneOf<string, Candidate>? Candidate { get; set; }

    /// <summary>
    /// When the information was submitted.
    /// </summary>
    [JsonPropertyName("submitted_at")]
    public DateTime? SubmittedAt { get; set; }

    /// <summary>
    /// The candidate's race.
    ///
    /// * `AMERICAN_INDIAN_OR_ALASKAN_NATIVE` - AMERICAN_INDIAN_OR_ALASKAN_NATIVE
    /// * `ASIAN` - ASIAN
    /// * `BLACK_OR_AFRICAN_AMERICAN` - BLACK_OR_AFRICAN_AMERICAN
    /// * `HISPANIC_OR_LATINO` - HISPANIC_OR_LATINO
    /// * `WHITE` - WHITE
    /// * `NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER` - NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER
    /// * `TWO_OR_MORE_RACES` - TWO_OR_MORE_RACES
    /// * `DECLINE_TO_SELF_IDENTIFY` - DECLINE_TO_SELF_IDENTIFY
    /// </summary>
    [JsonPropertyName("race")]
    public OneOf<RaceEnum, string>? Race { get; set; }

    /// <summary>
    /// The candidate's gender.
    ///
    /// * `MALE` - MALE
    /// * `FEMALE` - FEMALE
    /// * `NON-BINARY` - NON-BINARY
    /// * `OTHER` - OTHER
    /// * `DECLINE_TO_SELF_IDENTIFY` - DECLINE_TO_SELF_IDENTIFY
    /// </summary>
    [JsonPropertyName("gender")]
    public OneOf<GenderEnum, string>? Gender { get; set; }

    /// <summary>
    /// The candidate's veteran status.
    ///
    /// * `I_AM_NOT_A_PROTECTED_VETERAN` - I_AM_NOT_A_PROTECTED_VETERAN
    /// * `I_IDENTIFY_AS_ONE_OR_MORE_OF_THE_CLASSIFICATIONS_OF_A_PROTECTED_VETERAN` - I_IDENTIFY_AS_ONE_OR_MORE_OF_THE_CLASSIFICATIONS_OF_A_PROTECTED_VETERAN
    /// * `I_DONT_WISH_TO_ANSWER` - I_DONT_WISH_TO_ANSWER
    /// </summary>
    [JsonPropertyName("veteran_status")]
    public OneOf<VeteranStatusEnum, string>? VeteranStatus { get; set; }

    /// <summary>
    /// The candidate's disability status.
    ///
    /// * `YES_I_HAVE_A_DISABILITY_OR_PREVIOUSLY_HAD_A_DISABILITY` - YES_I_HAVE_A_DISABILITY_OR_PREVIOUSLY_HAD_A_DISABILITY
    /// * `NO_I_DONT_HAVE_A_DISABILITY` - NO_I_DONT_HAVE_A_DISABILITY
    /// * `I_DONT_WISH_TO_ANSWER` - I_DONT_WISH_TO_ANSWER
    /// </summary>
    [JsonPropertyName("disability_status")]
    public OneOf<DisabilityStatusEnum, string>? DisabilityStatus { get; set; }

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
