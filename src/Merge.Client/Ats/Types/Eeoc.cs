using System.Text.Json.Serialization;
using Merge.Client.Ats;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public class Eeoc
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
    /// The candidate being represented.
    /// </summary>
    [JsonPropertyName("candidate")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Candidate>>))]
    public OneOf<string, Candidate>? Candidate { get; init; }

    /// <summary>
    /// When the information was submitted.
    /// </summary>
    [JsonPropertyName("submitted_at")]
    public DateTime? SubmittedAt { get; init; }

    /// <summary>
    /// The candidate's race.
    ///
    /// - `AMERICAN_INDIAN_OR_ALASKAN_NATIVE` - AMERICAN_INDIAN_OR_ALASKAN_NATIVE
    /// - `ASIAN` - ASIAN
    /// - `BLACK_OR_AFRICAN_AMERICAN` - BLACK_OR_AFRICAN_AMERICAN
    /// - `HISPANIC_OR_LATINO` - HISPANIC_OR_LATINO
    /// - `WHITE` - WHITE
    /// - `NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER` - NATIVE_HAWAIIAN_OR_OTHER_PACIFIC_ISLANDER
    /// - `TWO_OR_MORE_RACES` - TWO_OR_MORE_RACES
    /// - `DECLINE_TO_SELF_IDENTIFY` - DECLINE_TO_SELF_IDENTIFY
    /// </summary>
    [JsonPropertyName("race")]
    public RaceEnum? Race { get; init; }

    /// <summary>
    /// The candidate's gender.
    ///
    /// - `MALE` - MALE
    /// - `FEMALE` - FEMALE
    /// - `NON-BINARY` - NON-BINARY
    /// - `OTHER` - OTHER
    /// - `DECLINE_TO_SELF_IDENTIFY` - DECLINE_TO_SELF_IDENTIFY
    /// </summary>
    [JsonPropertyName("gender")]
    public GenderEnum? Gender { get; init; }

    /// <summary>
    /// The candidate's veteran status.
    ///
    /// - `I_AM_NOT_A_PROTECTED_VETERAN` - I_AM_NOT_A_PROTECTED_VETERAN
    /// - `I_IDENTIFY_AS_ONE_OR_MORE_OF_THE_CLASSIFICATIONS_OF_A_PROTECTED_VETERAN` - I_IDENTIFY_AS_ONE_OR_MORE_OF_THE_CLASSIFICATIONS_OF_A_PROTECTED_VETERAN
    /// - `I_DONT_WISH_TO_ANSWER` - I_DONT_WISH_TO_ANSWER
    /// </summary>
    [JsonPropertyName("veteran_status")]
    public VeteranStatusEnum? VeteranStatus { get; init; }

    /// <summary>
    /// The candidate's disability status.
    ///
    /// - `YES_I_HAVE_A_DISABILITY_OR_PREVIOUSLY_HAD_A_DISABILITY` - YES_I_HAVE_A_DISABILITY_OR_PREVIOUSLY_HAD_A_DISABILITY
    /// - `NO_I_DONT_HAVE_A_DISABILITY` - NO_I_DONT_HAVE_A_DISABILITY
    /// - `I_DONT_WISH_TO_ANSWER` - I_DONT_WISH_TO_ANSWER
    /// </summary>
    [JsonPropertyName("disability_status")]
    public DisabilityStatusEnum? DisabilityStatus { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; init; }
}
