using System.Text.Json.Serialization;
using Merge.Client.Hris;
using OneOf;

namespace Merge.Client.Hris;

public class BankInfo
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The employee with this bank account.
    /// </summary>
    [JsonPropertyName("employee")]
    public OneOf<string, Employee>? Employee { get; init; }

    /// <summary>
    /// The account number.
    /// </summary>
    [JsonPropertyName("account_number")]
    public string? AccountNumber { get; init; }

    /// <summary>
    /// The routing number.
    /// </summary>
    [JsonPropertyName("routing_number")]
    public string? RoutingNumber { get; init; }

    /// <summary>
    /// The bank name.
    /// </summary>
    [JsonPropertyName("bank_name")]
    public string? BankName { get; init; }

    /// <summary>
    /// The bank account type
    ///
    /// - `SAVINGS` - SAVINGS
    /// - `CHECKING` - CHECKING
    /// </summary>
    [JsonPropertyName("account_type")]
    public AccountTypeEnum? AccountType { get; init; }

    /// <summary>
    /// When the matching bank object was created in the third party system.
    /// </summary>
    [JsonPropertyName("remote_created_at")]
    public DateTime? RemoteCreatedAt { get; init; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; init; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object>? FieldMappings { get; init; }

    [JsonPropertyName("remote_data")]
    public List<RemoteData>? RemoteData { get; init; }
}
