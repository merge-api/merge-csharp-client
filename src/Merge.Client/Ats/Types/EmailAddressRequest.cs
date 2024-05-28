using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class EmailAddressRequest
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
    public EmailAddressTypeEnum? EmailAddressType { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
