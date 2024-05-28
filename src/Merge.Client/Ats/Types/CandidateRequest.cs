using System.Text.Json.Serialization;
using Merge.Client.Ats;
using OneOf;

#nullable enable

namespace Merge.Client.Ats;

public class CandidateRequest
{
    /// <summary>
    /// The candidate's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; init; }

    /// <summary>
    /// The candidate's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; init; }

    /// <summary>
    /// The candidate's current company.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; init; }

    /// <summary>
    /// The candidate's current title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    /// <summary>
    /// When the most recent interaction with the candidate occurred.
    /// </summary>
    [JsonPropertyName("last_interaction_at")]
    public DateTime? LastInteractionAt { get; init; }

    /// <summary>
    /// Whether or not the candidate is private.
    /// </summary>
    [JsonPropertyName("is_private")]
    public bool? IsPrivate { get; init; }

    /// <summary>
    /// Whether or not the candidate can be emailed.
    /// </summary>
    [JsonPropertyName("can_email")]
    public bool? CanEmail { get; init; }

    /// <summary>
    /// The candidate's locations.
    /// </summary>
    [JsonPropertyName("locations")]
    public List<string?>? Locations { get; init; }

    [JsonPropertyName("phone_numbers")]
    public List<PhoneNumberRequest>? PhoneNumbers { get; init; }

    [JsonPropertyName("email_addresses")]
    public List<EmailAddressRequest>? EmailAddresses { get; init; }

    [JsonPropertyName("urls")]
    public List<UrlRequest>? Urls { get; init; }

    /// <summary>
    /// Array of `Tag` names as strings.
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string?>? Tags { get; init; }

    /// <summary>
    /// Array of `Application` object IDs.
    /// </summary>
    [JsonPropertyName("applications")]
    public List<OneOf<string, Application>?>? Applications { get; init; }

    /// <summary>
    /// Array of `Attachment` object IDs.
    /// </summary>
    [JsonPropertyName("attachments")]
    public List<OneOf<string, Attachment>?>? Attachments { get; init; }

    [JsonPropertyName("remote_template_id")]
    public string? RemoteTemplateId { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
