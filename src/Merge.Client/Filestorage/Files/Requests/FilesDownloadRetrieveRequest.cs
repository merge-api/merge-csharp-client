using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Filestorage;

public record FilesDownloadRetrieveRequest
{
    /// <summary>
    /// If provided, specifies the export format of the file to be downloaded. For information on supported export formats, please refer to our <a href='https://help.merge.dev/en/articles/8615316-file-export-and-download-specification' target='_blank'>export format help center article</a>.
    /// </summary>
    public string? MimeType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
