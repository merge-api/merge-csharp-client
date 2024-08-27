using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

public record ObjectClassDescriptionRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("origin_type")]
    public required OriginTypeEnum OriginType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
