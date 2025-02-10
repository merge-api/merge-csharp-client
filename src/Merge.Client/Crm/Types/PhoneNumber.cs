using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public record PhoneNumber
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
    /// The phone number.
    /// </summary>
    [JsonPropertyName("phone_number")]
    public string? PhoneNumber_ { get; set; }

    /// <summary>
    /// The phone number's type.
    /// </summary>
    [JsonPropertyName("phone_number_type")]
    public string? PhoneNumberType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
