using System.Text.Json.Serialization;
using Merge.Client.Ats;
using OneOf;

namespace Merge.Client.Ats;

public class Scorecard
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
    /// The application being scored.
    /// </summary>
    [JsonPropertyName("application")]
    public OneOf<string, Application>? Application { get; init; }

    /// <summary>
    /// The interview being scored.
    /// </summary>
    [JsonPropertyName("interview")]
    public OneOf<string, ScheduledInterview>? Interview { get; init; }

    /// <summary>
    /// The interviewer doing the scoring.
    /// </summary>
    [JsonPropertyName("interviewer")]
    public OneOf<string, RemoteUser>? Interviewer { get; init; }

    /// <summary>
    /// When the third party's scorecard was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    /// <summary>
    /// When the scorecard was submitted.
    /// </summary>
    [JsonPropertyName("submitted_at")]
    public DateTime? SubmittedAt { get; init; }

    /// <summary>
    /// The inteviewer's recommendation.
    ///
    /// - `DEFINITELY_NO` - DEFINITELY_NO
    /// - `NO` - NO
    /// - `YES` - YES
    /// - `STRONG_YES` - STRONG_YES
    /// - `NO_DECISION` - NO_DECISION
    /// </summary>
    [JsonPropertyName("overall_recommendation")]
    public OverallRecommendationEnum? OverallRecommendation { get; init; }

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
