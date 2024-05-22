using System.Text.Json.Serialization;

namespace Merge.Client.Crm;

public class PhoneNumber
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
    /// The phone number.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber_ { get; init; }

    /// <summary>
    /// The phone number's type.
    /// </summary>
    [JsonPropertyName("phone_number_type")]
    public string? PhoneNumberType { get; init; }
}
