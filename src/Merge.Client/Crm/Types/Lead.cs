using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Crm;

/// <summary>
/// # The Lead Object
/// ### Description
/// The `Lead` object is used to represent an individual who is a potential customer.
/// ### Usage Example
/// TODO
/// </summary>
public record Lead
{
    [JsonAccess(JsonAccessType.ReadOnly)]
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
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The lead's owner.
    /// </summary>
    [JsonPropertyName("owner")]
    public OneOf<string, User>? Owner { get; set; }

    /// <summary>
    /// The lead's source.
    /// </summary>
    [JsonPropertyName("lead_source")]
    public string? LeadSource { get; set; }

    /// <summary>
    /// The lead's title.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

    /// <summary>
    /// The lead's company.
    /// </summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>
    /// The lead's first name.
    /// </summary>
    [JsonPropertyName("first_name")]
    public string? FirstName { get; set; }

    /// <summary>
    /// The lead's last name.
    /// </summary>
    [JsonPropertyName("last_name")]
    public string? LastName { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("addresses")]
    public IEnumerable<Address>? Addresses { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("email_addresses")]
    public IEnumerable<EmailAddress>? EmailAddresses { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("phone_numbers")]
    public IEnumerable<PhoneNumber>? PhoneNumbers { get; set; }

    /// <summary>
    /// When the third party's lead was updated.
    /// </summary>
    [JsonPropertyName("remote_updated_at")]
    public DateTime? RemoteUpdatedAt { get; set; }

    /// <summary>
    /// When the third party's lead was created.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// When the lead was converted.
    /// </summary>
    [JsonPropertyName("converted_date")]
    public DateTime? ConvertedDate { get; set; }

    /// <summary>
    /// The contact of the converted lead.
    /// </summary>
    [JsonPropertyName("converted_contact")]
    public OneOf<string, Contact>? ConvertedContact { get; set; }

    /// <summary>
    /// The account of the converted lead.
    /// </summary>
    [JsonPropertyName("converted_account")]
    public OneOf<string, Account>? ConvertedAccount { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    [JsonAccess(JsonAccessType.ReadOnly)]
    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteField>? RemoteFields { get; set; }

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
