using Merge.Client.Core;

namespace Merge.Client.Accounting;

public record EmployeesListRequest
{
    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public string? Expand { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    public bool? IncludeDeletedData { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include shell records. Shell records are empty records (they may contain some metadata but all other fields are null).
    /// </summary>
    public bool? IncludeShellData { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
