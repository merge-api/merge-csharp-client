using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Ats;

/// <summary>
/// # The Attachment Object
/// ### Description
/// The `Attachment` object is used to represent a file attached to a candidate.
/// ### Usage Example
/// Fetch from the `LIST Attachments` endpoint and view attachments accessible by a company.
/// </summary>
public record AttachmentRequest
{
    /// <summary>
    /// The attachment's name.
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; set; }

    /// <summary>
    /// The attachment's url.
    /// </summary>
    [JsonPropertyName("file_url")]
    public string? FileUrl { get; set; }

    [JsonPropertyName("candidate")]
    public string? Candidate { get; set; }

    /// <summary>
    /// The attachment's type.
    ///
    /// * `RESUME` - RESUME
    /// * `COVER_LETTER` - COVER_LETTER
    /// * `OFFER_LETTER` - OFFER_LETTER
    /// * `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("attachment_type")]
    public AttachmentTypeEnum? AttachmentType { get; set; }

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
