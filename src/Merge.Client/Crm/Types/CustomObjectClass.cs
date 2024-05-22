using System.Text.Json.Serialization;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class CustomObjectClass
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

    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; init; }

    /// <summary>
    /// The custom object class's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The custom object class's description.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The custom object class's singular and plural labels.
    /// </summary>
    [JsonPropertyName("labels")]
    public Dictionary<string, string?>? Labels { get; init; }

    [JsonPropertyName("fields")]
    public List<RemoteFieldClassForCustomObjectClass>? Fields { get; init; }

    /// <summary>
    /// The types of associations with other models that the custom object class can have.
    /// </summary>
    [JsonPropertyName("association_types")]
    public List<Dictionary<string, object>>? AssociationTypes { get; init; }
}
