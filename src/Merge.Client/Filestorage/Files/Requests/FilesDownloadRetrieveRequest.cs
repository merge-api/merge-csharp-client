using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public record FilesDownloadRetrieveRequest
{
    /// <summary>
    /// Whether to include shell records. Shell records are empty records (they may contain some metadata but all other fields are null).
    /// </summary>
    public bool? IncludeShellData { get; set; }

    /// <summary>
    /// If provided, specifies the export format of the file to be downloaded. For information on supported export formats, please refer to our &lt;a href='https://help.merge.dev/en/articles/8615316-file-export-and-download-specification' target='_blank'&gt;export format help center article&lt;/a&gt;.
    /// </summary>
    public string? MimeType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
