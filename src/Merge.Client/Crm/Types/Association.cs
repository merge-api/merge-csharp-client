using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Crm;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public class Association
{
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

    [JsonPropertyName("source_object")]
    public string? SourceObject { get; init; }

    [JsonPropertyName("target_object")]
    public string? TargetObject { get; init; }

    /// <summary>
    /// The association type the association belongs to.
    /// </summary>
    [JsonPropertyName("association_type")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, AssociationType>>))]
    public OneOf<string, AssociationType>? AssociationType { get; init; }
}
