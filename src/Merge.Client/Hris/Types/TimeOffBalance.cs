using System.Text.Json.Serialization;
using Merge.Client.Hris;
using OneOf;

namespace Merge.Client.Hris;

public class TimeOffBalance
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The employee the balance belongs to.
    /// </summary>
    [JsonPropertyName("employee")]
    public OneOf<string, Employee>? Employee { get; init; }

    /// <summary>
    /// The current remaining PTO balance, always measured in terms of hours.
    /// </summary>
    [JsonPropertyName("balance")]
    public double? Balance { get; init; }

    /// <summary>
    /// The amount of PTO used in terms of hours.
    /// </summary>
    [JsonPropertyName("used")]
    public double? Used { get; init; }

    /// <summary>
    /// The policy type of this time off balance.
    ///
    /// - `VACATION` - VACATION
    /// - `SICK` - SICK
    /// - `PERSONAL` - PERSONAL
    /// - `JURY_DUTY` - JURY_DUTY
    /// - `VOLUNTEER` - VOLUNTEER
    /// - `BEREAVEMENT` - BEREAVEMENT
    /// </summary>
    [JsonPropertyName("policy_type")]
    public PolicyTypeEnum? PolicyType { get; init; }

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
