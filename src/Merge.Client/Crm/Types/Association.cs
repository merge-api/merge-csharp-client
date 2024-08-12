using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public record Association
{
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

    [JsonPropertyName("source_object")]
    public string? SourceObject { get; set; }

    [JsonPropertyName("target_object")]
    public string? TargetObject { get; set; }

    /// <summary>
    /// The association type the association belongs to.
    /// </summary>
    [JsonPropertyName("association_type")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, AssociationType>>))]
    public OneOf<string, AssociationType>? AssociationType { get; set; }
}
