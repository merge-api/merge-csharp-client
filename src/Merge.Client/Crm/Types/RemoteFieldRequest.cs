using System.Text.Json.Serialization;
using Merge.Client.Crm;
using OneOf;

namespace Merge.Client.Crm;

public class RemoteFieldRequest
{
    [JsonPropertyName("remote_field_class")]
    public OneOf<string, RemoteFieldClass> RemoteFieldClass { get; init; }

    [JsonPropertyName("value")]
    public string? Value { get; init; }
}
