using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;
using OneOf;

namespace Merge.Ats;

/// <summary>
/// # The ScreeningQuestionAnswer Object
/// ### Description
/// The `ScreeningQuestionAnswer` object is used to represent candidate responses to a screening question, for a specific application.
///
/// ### Usage Example
/// TODO
/// </summary>
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

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public object? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public object? LinkedAccountParams { get; set; }

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
