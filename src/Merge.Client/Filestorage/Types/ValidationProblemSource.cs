using System.Text.Json.Serialization;

namespace Merge.Client.Filestorage;

public class ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public string Pointer { get; init; }
}
