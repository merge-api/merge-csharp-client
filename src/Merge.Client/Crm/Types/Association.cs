using System.Text.Json.Serialization;
using Merge.Client.Crm;
using OneOf;

namespace Merge.Client.Crm;

public class Association
{
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; init; }

    /// <summary>
    /// This is the datetime that this object was last updated by Merge
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    [JsonPropertyName("source_object")]
    public Dictionary<string, object>? SourceObject { get; init; }

    [JsonPropertyName("target_object")]
    public Dictionary<string, object>? TargetObject { get; init; }

    [JsonPropertyName("association_type")]
    public OneOf<string, AssociationType>? AssociationType { get; init; }
}
