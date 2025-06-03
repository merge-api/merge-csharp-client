using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ats;

/// <summary>
/// # The Scorecard Object
/// ### Description
/// The `Scorecard` object is used to represent an interviewer's candidate recommendation based on a particular interview.
/// ### Usage Example
/// Fetch from the `LIST Scorecards` endpoint and filter by `application` to show all scorecard for an applicant.
/// </summary>
public record Scorecard
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
    /// The application being scored.
    /// </summary>
    [JsonPropertyName("application")]
    public OneOf<string, Application>? Application { get; set; }

    /// <summary>
    /// The interview being scored.
    /// </summary>
    [JsonPropertyName("interview")]
    public OneOf<string, ScheduledInterview>? Interview { get; set; }

    /// <summary>
    /// The interviewer doing the scoring.
    /// </summary>
    [JsonPropertyName("interviewer")]
    public OneOf<string, RemoteUser>? Interviewer { get; set; }

    /// <summary>
    /// When the third party's scorecard was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// When the scorecard was submitted.
    /// </summary>
    [JsonPropertyName("submitted_at")]
    public DateTime? SubmittedAt { get; set; }

    /// <summary>
    /// The inteviewer's recommendation.
    ///
    /// * `DEFINITELY_NO` - DEFINITELY_NO
    /// * `NO` - NO
    /// * `YES` - YES
    /// * `STRONG_YES` - STRONG_YES
    /// * `NO_DECISION` - NO_DECISION
    /// </summary>
    [JsonPropertyName("overall_recommendation")]
    public OverallRecommendationEnum? OverallRecommendation { get; set; }

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
