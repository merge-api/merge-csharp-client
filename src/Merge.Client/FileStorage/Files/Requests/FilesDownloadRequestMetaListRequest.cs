using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[Serializable]
public record FilesDownloadRequestMetaListRequest
{
    /// <summary>
    /// If provided, will only return objects created after this datetime.
    /// </summary>
    [JsonIgnore]
    public string? CreatedAfter { get; set; }

    /// <summary>
    /// If provided, will only return objects created before this datetime.
    /// </summary>
    [JsonIgnore]
    public string? CreatedBefore { get; set; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    [JsonIgnore]
    public string? Cursor { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonIgnore]
    public bool? IncludeDeletedData { get; set; }

    /// <summary>
    /// A comma-separated list of preferred MIME types in order of priority. If supported by the third-party provider, the file(s) will be returned in the first supported MIME type from the list. The default MIME type is PDF. To see supported MIME types by file type, refer to our &lt;a href='https://help.merge.dev/en/articles/8615316-file-export-and-download-specification' target='_blank'&gt;export format help center article&lt;/a&gt;.
    /// </summary>
    [JsonIgnore]
    public string? MimeTypes { get; set; }

    /// <summary>
    /// If provided, will only return objects modified after this datetime.
    /// </summary>
    [JsonIgnore]
    public string? ModifiedAfter { get; set; }

    /// <summary>
    /// If provided, will only return objects modified before this datetime.
    /// </summary>
    [JsonIgnore]
    public string? ModifiedBefore { get; set; }

    /// <summary>
    /// Overrides the default ordering for this endpoint. Possible values include: created_at, -created_at, modified_at, -modified_at.
    /// </summary>
    [JsonIgnore]
    public FilesDownloadRequestMetaListRequestOrderBy? OrderBy { get; set; }

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
