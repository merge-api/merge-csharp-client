using System.Text.Json.Serialization;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class CustomObjectClass
{
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    [JsonPropertyName("description")]
    public string? Description { get; init; }

    [JsonPropertyName("labels")]
    public Dictionary<string, string?>? Labels { get; init; }

    [JsonPropertyName("fields")]
    public List<RemoteFieldClassForCustomObjectClass>? Fields { get; init; }

    [JsonPropertyName("association_types")]
    public List<Dictionary<string, object>>? AssociationTypes { get; init; }

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
}
