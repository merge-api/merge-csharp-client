using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public record FileStorageFolderResponse
{
    [JsonPropertyName("model")]
    public required Folder Model { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<WarningValidationProblem> Warnings { get; set; } =
        new List<WarningValidationProblem>();

    [JsonPropertyName("errors")]
    public IEnumerable<ErrorValidationProblem> Errors { get; set; } =
        new List<ErrorValidationProblem>();

    [JsonPropertyName("logs")]
    public IEnumerable<DebugModeLog>? Logs { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
