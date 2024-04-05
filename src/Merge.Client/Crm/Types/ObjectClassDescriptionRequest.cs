using System.Text.Json.Serialization;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class ObjectClassDescriptionRequest
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("origin_type")]
    public OriginTypeEnum OriginType { get; init; }
}
