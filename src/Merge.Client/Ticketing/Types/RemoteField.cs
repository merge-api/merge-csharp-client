using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Ticketing;
using OneOf;

#nullable enable

namespace Merge.Client.Ticketing;

public class RemoteField
{
    [JsonPropertyName("remote_field_class")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, RemoteFieldClass>>))]
    public OneOf<string, RemoteFieldClass> RemoteFieldClass { get; init; }

    [JsonPropertyName("value")]
    public object? Value { get; init; }
}
