using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public record ScreeningQuestion
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
    /// The job associated with the screening question.
    /// </summary>
    [JsonPropertyName("job")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Job>>))]
    public OneOf<string, Job>? Job { get; set; }

    /// <summary>
    /// The description of the screening question
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The title of the screening question
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The data type for the screening question.
    ///
    /// - `DATE` - DATE
    /// - `FILE` - FILE
    /// - `SINGLE_SELECT` - SINGLE_SELECT
    /// - `MULTI_SELECT` - MULTI_SELECT
    /// - `SINGLE_LINE_TEXT` - SINGLE_LINE_TEXT
    /// - `MULTI_LINE_TEXT` - MULTI_LINE_TEXT
    /// - `NUMERIC` - NUMERIC
    /// - `BOOLEAN` - BOOLEAN
    /// </summary>
    [JsonPropertyName("type")]
    public ScreeningQuestionTypeEnum? Type { get; set; }

    /// <summary>
    /// Whether or not the screening question is required.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    [JsonPropertyName("options")]
    public IEnumerable<object>? Options { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }
}
