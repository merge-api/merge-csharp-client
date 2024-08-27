using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record MultipartFormFieldRequest
{
    /// <summary>
    /// The name of the form field
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The data for the form field.
    /// </summary>
    [JsonPropertyName("data")]
    public required string Data { get; set; }

    /// <summary>
    /// The encoding of the value of `data`. Defaults to `RAW` if not defined.
    ///
    /// - `RAW` - RAW
    /// - `BASE64` - BASE64
    /// - `GZIP_BASE64` - GZIP_BASE64
    /// </summary>
    [JsonPropertyName("encoding")]
    public EncodingEnum? Encoding { get; set; }

    /// <summary>
    /// The file name of the form field, if the field is for a file.
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; set; }

    /// <summary>
    /// The MIME type of the file, if the field is for a file.
    /// </summary>
    [JsonPropertyName("content_type")]
    public string? ContentType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
