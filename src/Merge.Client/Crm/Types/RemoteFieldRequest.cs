using System.Text.Json.Serialization;
using Merge.Client.Core;
using OneOf;

#nullable enable

namespace Merge.Client.Crm;

public record RemoteFieldRequest
{
    [JsonPropertyName("remote_field_class")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, RemoteFieldClass>>))]
    public required OneOf<string, RemoteFieldClass> RemoteFieldClass { get; set; }

    [JsonPropertyName("value")]
    public object? Value { get; set; }
}
