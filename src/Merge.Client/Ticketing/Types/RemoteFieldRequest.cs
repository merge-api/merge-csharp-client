using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

namespace Merge.Client.Ticketing;

public record RemoteFieldRequest
{
    [JsonPropertyName("remote_field_class")]
    public required OneOf<string, RemoteFieldClass> RemoteFieldClass { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
