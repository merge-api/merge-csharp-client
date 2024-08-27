using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record PatchedCandidateRequest
{
    /// <summary>
    /// The candidate's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    /// <summary>
    /// The candidate's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    /// <summary>
    /// The candidate's current company.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// The candidate's current title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// When the most recent interaction with the candidate occurred.
    /// </summary>
    [JsonPropertyName("last_interaction_at")]
    public DateTime? LastInteractionAt { get; set; }

    /// <summary>
    /// Whether or not the candidate is private.
    /// </summary>
    [JsonPropertyName("is_private")]
    public bool? IsPrivate { get; set; }

    /// <summary>
    /// Whether or not the candidate can be emailed.
    /// </summary>
    [JsonPropertyName("can_email")]
    public bool? CanEmail { get; set; }

    /// <summary>
    /// The candidate's locations.
    /// </summary>
    [JsonPropertyName("locations")]
    public IEnumerable<string>? Locations { get; set; }

    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumberRequest>? PhoneNumbers { get; set; }

    [JsonPropertyName("email_addresses")]
    public IEnumerable<EmailAddressRequest>? EmailAddresses { get; set; }

    [JsonPropertyName("urls")]
    public IEnumerable<UrlRequest>? Urls { get; set; }

    /// <summary>
    /// Array of `Tag` names as strings.
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<string>? Tags { get; set; }

    /// <summary>
    /// Array of `Application` object IDs.
    /// </summary>
    [JsonPropertyName("applications")]
    public IEnumerable<string>? Applications { get; set; }

    /// <summary>
    /// Array of `Attachment` object IDs.
    /// </summary>
    [JsonPropertyName("attachments")]
    public IEnumerable<string>? Attachments { get; set; }

    [JsonPropertyName("remote_template_id")]
    public string? RemoteTemplateId { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
