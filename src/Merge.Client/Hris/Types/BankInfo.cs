using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Hris;

public record BankInfo
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

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
    /// The employee with this bank account.
    /// </summary>
    [JsonPropertyName("employee")]
    public OneOf<string, Employee>? Employee { get; set; }

    /// <summary>
    /// The account number.
    /// </summary>
    [JsonPropertyName("account_number")]
    public string? AccountNumber { get; set; }

    /// <summary>
    /// The routing number.
    /// </summary>
    [JsonPropertyName("routing_number")]
    public string? RoutingNumber { get; set; }

    /// <summary>
    /// The bank name.
    /// </summary>
    [JsonPropertyName("bank_name")]
    public string? BankName { get; set; }

    /// <summary>
    /// The bank account type
    ///
    /// - `SAVINGS` - SAVINGS
    /// - `CHECKING` - CHECKING
    /// </summary>
    [JsonPropertyName("account_type")]
    public AccountTypeEnum? AccountType { get; set; }

    /// <summary>
    /// When the matching bank object was created in the third party system.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
