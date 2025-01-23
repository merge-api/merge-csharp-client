using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

public record AsyncPostTaskResult
{
    [JsonPropertyName("status_code")]
    public int? StatusCode { get; set; }

    [JsonPropertyName("response")]
    public Dictionary<string, object?>? Response { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
