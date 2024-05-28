using System.Text.Json.Serialization;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class MultipartFormFieldRequest
{
    /// <summary>
    /// The name of the form field
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; init; }

    /// <summary>
    /// The data for the form field.
    /// </summary>
    [JsonPropertyName("data")]
    public string Data { get; init; }

    /// <summary>
    /// The encoding of the value of `data`. Defaults to `RAW` if not defined.
    ///
    /// - `RAW` - RAW
    /// - `BASE64` - BASE64
    /// - `GZIP_BASE64` - GZIP_BASE64
    /// </summary>
    [JsonPropertyName("encoding")]
    public EncodingEnum? Encoding { get; init; }

    /// <summary>
    /// The file name of the form field, if the field is for a file.
    /// </summary>
    [JsonPropertyName("file_name")]
    public string? FileName { get; init; }

    /// <summary>
    /// The MIME type of the file, if the field is for a file.
    /// </summary>
    [JsonPropertyName("content_type")]
    public string? ContentType { get; init; }
}
