using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public class ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public string Pointer { get; init; }
}
