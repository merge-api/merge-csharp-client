using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public record EmailAddressRequest
{
    /// <summary>
    /// The email address.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// The type of email address.
    ///
    /// - `PERSONAL` - PERSONAL
    /// - `WORK` - WORK
    /// - `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("email_address_type")]
    public EmailAddressTypeEnum? EmailAddressType { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }
}
