using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class RemoteField
{
    [JsonPropertyName("remote_field_class")]
    public OneOf<string, RemoteFieldClass> RemoteFieldClass { get; init; }

    [JsonPropertyName("value")]
    public object? Value { get; init; }
}
