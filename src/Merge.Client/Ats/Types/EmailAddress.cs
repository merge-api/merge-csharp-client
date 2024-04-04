using System.Text.Json.Serialization;
using StringEnum;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class EmailAddress
{
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
    public StringEnum<EmailAddressTypeEnum>? EmailAddressType { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }
}
