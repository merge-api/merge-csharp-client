using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class CustomObject
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; init; }

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

    /// <summary>
    /// The custom object class the custom object record belongs to.
    /// </summary>
    [JsonPropertyName("object_class")]
    public string? ObjectClass { get; init; }

    /// <summary>
    /// The fields and values contained within the custom object record.
    /// </summary>
    [JsonPropertyName("fields")]
    public Dictionary<string, object>? Fields { get; init; }

    [JsonPropertyName("remote_fields")]
    public List<RemoteField>? RemoteFields { get; init; }
}
