using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class Comment
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The author of the Comment, if the author is a User.
    /// </summary>
    [JsonPropertyName("user")]
    public OneOf<string, User>? User { get; init; }

    /// <summary>
    /// The author of the Comment, if the author is a Contact.
    /// </summary>
    [JsonPropertyName("contact")]
    public OneOf<string, Contact>? Contact { get; init; }

    /// <summary>
    /// The comment's text body.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; init; }

    /// <summary>
    /// The comment's text body formatted as html.
    /// </summary>
    [JsonPropertyName("html_body")]
    public string? HtmlBody { get; init; }

    /// <summary>
    /// The ticket associated with the comment.
    /// </summary>
    [JsonPropertyName("ticket")]
    public OneOf<string, Ticket>? Ticket { get; init; }

    /// <summary>
    /// Whether or not the comment is internal.
    /// </summary>
    [JsonPropertyName("is_private")]
    public bool? IsPrivate { get; init; }

    /// <summary>
    /// When the third party's comment was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
