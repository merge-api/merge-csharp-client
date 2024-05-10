using System.Text.Json.Serialization;

namespace Merge.Client.Crm;

public class AssociationSubType
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    [JsonPropertyName("origin_type")]
    public string? OriginType { get; init; }
}
