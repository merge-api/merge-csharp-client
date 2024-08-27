using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

public record CustomObjectClass
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The custom object class's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The custom object class's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The custom object class's singular and plural labels.
    /// </summary>
    [JsonPropertyName("labels")]
    public Dictionary<string, string?>? Labels { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<RemoteFieldClassForCustomObjectClass>? Fields { get; set; }

    /// <summary>
    /// The types of associations with other models that the custom object class can have.
    /// </summary>
    [JsonPropertyName("association_types")]
    public IEnumerable<Dictionary<string, object?>>? AssociationTypes { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
