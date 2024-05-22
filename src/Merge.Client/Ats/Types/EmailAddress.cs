using System.Text.Json.Serialization;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

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
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    /// <summary>
    /// The type of email address.
    ///
    /// - `PERSONAL` - PERSONAL
    /// - `WORK` - WORK
    /// - `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("email_address_type")]
    public EmailAddressTypeEnum? EmailAddressType { get; init; }
}
