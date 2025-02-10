using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ats;

public record Scorecard
{
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
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
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
    /// - `DEFINITELY_NO` - DEFINITELY_NO
    /// - `NO` - NO
    /// - `YES` - YES
    /// - `STRONG_YES` - STRONG_YES
    /// - `NO_DECISION` - NO_DECISION
    /// </summary>
    [JsonPropertyName("overall_recommendation")]
    public OverallRecommendationEnum? OverallRecommendation { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
