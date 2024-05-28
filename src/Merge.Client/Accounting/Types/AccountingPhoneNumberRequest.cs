using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public class AccountingPhoneNumberRequest
{
    /// <summary>
    /// The phone number.
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; init; }

    /// <summary>
    /// The phone number's type.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; init; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object>? IntegrationParams { get; init; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object>? LinkedAccountParams { get; init; }
}
