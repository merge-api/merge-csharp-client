using System.Text.Json.Serialization;
using Merge.Client.Ticketing;
using OneOf;

#nullable enable

namespace Merge.Client.Ticketing;

public class RemoteFieldRequest
{
    [JsonPropertyName("remote_field_class")]
    public OneOf<string, RemoteFieldClass> RemoteFieldClass { get; init; }

    [JsonPropertyName("value")]
    public string? Value { get; init; }
}
