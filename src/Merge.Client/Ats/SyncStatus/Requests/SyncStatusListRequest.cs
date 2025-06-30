using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[Serializable]
public record SyncStatusListRequest
{
    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    [JsonIgnore]
    public string? Cursor { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    [JsonIgnore]
    public int? PageSize { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
