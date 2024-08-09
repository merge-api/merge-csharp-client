using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record PhoneNumberRequest
{
    /// <summary>
    /// The phone number.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

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
    public PhoneNumberTypeEnum? PhoneNumberType { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }
}
