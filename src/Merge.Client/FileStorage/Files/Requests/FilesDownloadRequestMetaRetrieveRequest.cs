using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[Serializable]
public record FilesDownloadRequestMetaRetrieveRequest
{
    /// <summary>
    /// If provided, specifies the export format of the file to be downloaded. For information on supported export formats, please refer to our &lt;a href='https://help.merge.dev/en/articles/8615316-file-export-and-download-specification' target='_blank'&gt;export format help center article&lt;/a&gt;.
    /// </summary>
    [JsonIgnore]
    public string? MimeType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
