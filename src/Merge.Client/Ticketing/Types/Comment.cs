using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ticketing;

public record Comment
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
    /// The author of the Comment, if the author is a User. If the third party does not support specifying an author, we will append "[Posted on behalf of {name}]" to the comment.
    /// </summary>
    [JsonPropertyName("user")]
    public OneOf<string, User>? User { get; set; }

    /// <summary>
    /// The author of the Comment, if the author is a Contact.If the third party does not support specifying an author, we will append "[Posted on behalf of {name}]" to the comment.
    /// </summary>
    [JsonPropertyName("contact")]
    public OneOf<string, Contact>? Contact { get; set; }

    /// <summary>
    /// The comment's text body.
    /// </summary>
    [JsonPropertyName("body")]
    public string? Body { get; set; }

    /// <summary>
    /// The comment's text body formatted as html.
    /// </summary>
    [JsonPropertyName("html_body")]
    public string? HtmlBody { get; set; }

    /// <summary>
    /// The ticket associated with the comment.
    /// </summary>
    [JsonPropertyName("ticket")]
    public OneOf<string, Ticket>? Ticket { get; set; }

    /// <summary>
    /// Whether or not the comment is internal.
    /// </summary>
    [JsonPropertyName("is_private")]
    public bool? IsPrivate { get; set; }

    /// <summary>
    /// When the third party's comment was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

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
