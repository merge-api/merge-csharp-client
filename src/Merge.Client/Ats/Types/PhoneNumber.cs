using System.Text.Json.Serialization;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class PhoneNumber
{
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The phone number.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; init; }

    /// <summary>
    /// The type of phone number.
    ///
    /// - `HOME` - HOME
    /// - `WORK` - WORK
    /// - `MOBILE` - MOBILE
    /// - `SKYPE` - SKYPE
    /// - `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("phone_number_type")]
    public PhoneNumberTypeEnum? PhoneNumberType { get; init; }
}
