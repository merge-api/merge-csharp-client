using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Accounting;

/// <summary>
/// # The VendorCreditApplyLine Object
/// ### Description
/// The `VendorCreditApplyLine` object is used to represent a applied vendor credit.
///
/// ### Usage Example
/// Fetch from the `GET VendorCredit` endpoint and view the vendor credit's applied to lines.
/// </summary>
[Serializable]
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

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("integration_params")]
    public Dictionary<string, object?>? IntegrationParams { get; set; }

    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("linked_account_params")]
    public Dictionary<string, object?>? LinkedAccountParams { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
