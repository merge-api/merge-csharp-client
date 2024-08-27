using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

public record CreditNotesRetrieveRequest
{
    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public CreditNotesRetrieveRequestExpand? Expand { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Deprecated. Use show_enum_origins.
    /// </summary>
    public CreditNotesRetrieveRequestRemoteFields? RemoteFields { get; set; }

    /// <summary>
    /// A comma separated list of enum field names for which you'd like the original values to be returned, instead of Merge's normalized enum values. [Learn more](https://help.merge.dev/en/articles/8950958-show_enum_origins-query-parameter)
    /// </summary>
    public CreditNotesRetrieveRequestShowEnumOrigins? ShowEnumOrigins { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
