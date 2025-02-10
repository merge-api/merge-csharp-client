using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record AccountingPhoneNumberRequest
{
    /// <summary>
    /// The phone number.
    /// </summary>
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    /// <summary>
    /// The phone number's type.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
