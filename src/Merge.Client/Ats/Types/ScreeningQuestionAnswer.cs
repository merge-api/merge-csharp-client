using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public record ScreeningQuestionAnswer
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
    /// The screening question associated with the candidate’s answer. To determine the data type of the answer, you can expand on the screening question by adding `screening_question_answers.question` to the `expand` query parameter.
    /// </summary>
    [JsonPropertyName("question")]
    public OneOf<string, ScreeningQuestion>? Question { get; set; }

    /// <summary>
    /// The candidate’s response to the screening question.
    /// </summary>
    [JsonPropertyName("answer")]
    public string? Answer { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
