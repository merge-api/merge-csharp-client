using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public record AssociationSubType
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

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

    [JsonPropertyName("origin_type")]
    public string? OriginType { get; set; }
}
