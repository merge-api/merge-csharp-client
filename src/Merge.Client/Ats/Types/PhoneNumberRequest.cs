using System.Text.Json.Serialization;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class PhoneNumberRequest
{
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

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
