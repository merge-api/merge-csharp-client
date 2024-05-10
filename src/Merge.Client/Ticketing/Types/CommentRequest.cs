using System.Text.Json.Serialization;
using Merge.Client.Ticketing;
using OneOf;

namespace Merge.Client.Ticketing;

public class CommentRequest
{
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

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
