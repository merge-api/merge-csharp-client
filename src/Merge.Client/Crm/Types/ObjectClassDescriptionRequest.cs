using System.Text.Json.Serialization;
using StringEnum;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class ObjectClassDescriptionRequest
{
    [JsonPropertyName("id")]
    public string Id { get; init; }

    [JsonPropertyName("origin_type")]
    public StringEnum<OriginTypeEnum> OriginType { get; init; }
}
