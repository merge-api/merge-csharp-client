using System.Text.Json.Serialization;
using OneOf;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class RemoteField
{
    [JsonPropertyName("remote_field_class")]
    public OneOf<string, RemoteFieldClass> RemoteFieldClass { get; init; }

    [JsonPropertyName("value")]
    public object? Value { get; init; }
}
