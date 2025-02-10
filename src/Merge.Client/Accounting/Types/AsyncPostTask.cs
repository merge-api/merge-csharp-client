using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record AsyncPostTask
{
    [JsonPropertyName("status")]
    public required AsyncPostTaskStatusEnum Status { get; set; }

    [JsonPropertyName("result")]
    public required AsyncPostTaskResult Result { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
