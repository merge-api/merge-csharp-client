using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public record ValidationProblemSource
{
    [JsonPropertyName("pointer")]
    public required string Pointer { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
