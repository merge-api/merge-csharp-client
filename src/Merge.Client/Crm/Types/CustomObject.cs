using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

public record CustomObject
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The third-party API ID of the matching object.
    /// </summary>
    [JsonPropertyName("remote_id")]
    public string? RemoteId { get; set; }

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

    /// <summary>
    /// The custom object class the custom object record belongs to.
    /// </summary>
    [JsonPropertyName("object_class")]
    public string? ObjectClass { get; set; }

    /// <summary>
    /// The fields and values contained within the custom object record.
    /// </summary>
    [JsonPropertyName("fields")]
    public Dictionary<string, object?>? Fields { get; set; }

    [JsonPropertyName("remote_fields")]
    public IEnumerable<RemoteField>? RemoteFields { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
