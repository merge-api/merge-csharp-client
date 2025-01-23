using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public record ScreeningQuestionAnswerRequest
{
    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

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

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
