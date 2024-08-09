using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Hris;

public record TimeOffBalance
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
    /// The employee the balance belongs to.
    /// </summary>
    [JsonPropertyName("employee")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, Employee>>))]
    public OneOf<string, Employee>? Employee { get; set; }

    /// <summary>
    /// The current remaining PTO balance, always measured in terms of hours.
    /// </summary>
    [JsonPropertyName("balance")]
    public double? Balance { get; set; }

    /// <summary>
    /// The amount of PTO used in terms of hours.
    /// </summary>
    [JsonPropertyName("used")]
    public double? Used { get; set; }

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
    public PolicyTypeEnum? PolicyType { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    [JsonPropertyName("field_mappings")]
    public Dictionary<string, object?>? FieldMappings { get; set; }

    [JsonPropertyName("remote_data")]
    public IEnumerable<RemoteData>? RemoteData { get; set; }
}
