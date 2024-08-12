namespace Merge.Client.Filestorage;

public record FilesListRequest
{
    /// <summary>
    /// If provided, will only return objects created after this datetime.
    /// </summary>
    public DateTime? CreatedAfter { get; set; }

    /// <summary>
    /// If provided, will only return objects created before this datetime.
    /// </summary>
    public DateTime? CreatedBefore { get; set; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// Specifying a drive id returns only the files in that drive. Specifying null returns only the files outside the top-level drive.
    /// </summary>
    public string? DriveId { get; set; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public FilesListRequestExpand? Expand { get; set; }

    /// <summary>
    /// Specifying a folder id returns only the files in that folder. Specifying null returns only the files in root directory.
    /// </summary>
    public string? FolderId { get; set; }

    /// <summary>
    /// Whether to include data that was marked as deleted by third party webhooks.
    /// </summary>
    public bool? IncludeDeletedData { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// If provided, will only return files with these mime_types. Multiple values can be separated by commas.
    /// </summary>
    public string? MimeType { get; set; }

    /// <summary>
    /// If provided, only objects synced by Merge after this date time will be returned.
    /// </summary>
    public DateTime? ModifiedAfter { get; set; }

    /// <summary>
    /// If provided, only objects synced by Merge before this date time will be returned.
    /// </summary>
    public DateTime? ModifiedBefore { get; set; }

    /// <summary>
    /// If provided, will only return files with this name. This performs an exact match.
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    public string? RemoteId { get; set; }
}
