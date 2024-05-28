using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class FileStorageFileResponse
{
    [JsonPropertyName("model")]
    public File Model { get; init; }

    [JsonPropertyName("warnings")]
    public List<WarningValidationProblem> Warnings { get; init; }

    [JsonPropertyName("errors")]
    public List<ErrorValidationProblem> Errors { get; init; }

    [JsonPropertyName("logs")]
    public List<DebugModeLog>? Logs { get; init; }
}
