using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record RemoteField
{
    [JsonPropertyName("remote_field_class")]
    public required RemoteFieldClass RemoteFieldClass { get; set; }

    [JsonPropertyName("value")]
    public Dictionary<string, object?>? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
