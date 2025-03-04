using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record TransactionsRetrieveRequest
{
    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public TransactionsRetrieveRequestExpand? Expand { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
