using System.Text.Json.Serialization;

namespace Merge.Client.Crm;

public class EmailAddress
{
    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string? EmailAddress_ { get; init; }

    /// <summary>
    /// The email address's type.
    /// </summary>
    [JsonPropertyName("email_address_type")]
    public string? EmailAddressType { get; init; }
}
