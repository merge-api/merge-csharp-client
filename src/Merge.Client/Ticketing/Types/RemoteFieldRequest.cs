using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class RemoteFieldRequest
{
    [JsonPropertyName("remote_field_class")]
    public OneOf<string, RemoteFieldClass> RemoteFieldClass { get; init; }

    [JsonPropertyName("value")]
    public string? Value { get; init; }
}
