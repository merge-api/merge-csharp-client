using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public record ExternalTargetFieldApi
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("is_mapped")]
    public string? IsMapped { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
