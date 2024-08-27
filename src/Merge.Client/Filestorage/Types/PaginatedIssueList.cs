using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Filestorage;

public record PaginatedIssueList
{
    [JsonPropertyName("next")]
    public string? Next { get; set; }

    [JsonPropertyName("previous")]
    public string? Previous { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<Issue>? Results { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
