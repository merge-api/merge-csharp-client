using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.FileStorage.Users;

public record UsersRetrieveRequest
{
    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include shell records. Shell records are empty records (they may contain some metadata but all other fields are null).
    /// </summary>
    [JsonIgnore]
    public bool? IncludeShellData { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
