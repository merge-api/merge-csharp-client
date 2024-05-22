using System.Text.Json.Serialization;

namespace Merge.Client.Crm;

public class AssociationSubType
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

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

    [JsonPropertyName("origin_type")]
    public string? OriginType { get; init; }
}
