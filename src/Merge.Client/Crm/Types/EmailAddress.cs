using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record EmailAddress
{
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
    /// The email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress_ { get; set; }

    /// <summary>
    /// The email address's type.
    /// </summary>
    [JsonPropertyName("email_address_type")]
    public string? EmailAddressType { get; set; }
}
