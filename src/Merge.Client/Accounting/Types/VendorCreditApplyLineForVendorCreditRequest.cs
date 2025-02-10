using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

public record VendorCreditApplyLineForVendorCreditRequest
{
    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    [JsonPropertyName("invoice")]
    public OneOf<string, Invoice>? Invoice { get; set; }

    /// <summary>
    /// Date that the vendor credit is applied to the invoice.
    /// </summary>
    [JsonPropertyName("applied_date")]
    public DateTime? AppliedDate { get; set; }

    /// <summary>
    /// The amount of the VendorCredit applied to the invoice.
    /// </summary>
    [JsonPropertyName("applied_amount")]
    public string? AppliedAmount { get; set; }

    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
