using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public record TeamsRetrieveRequest
{
    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include shell records. Shell records are empty records (they may contain some metadata but all other fields are null).
    /// </summary>
    public bool? IncludeShellData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
