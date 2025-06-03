using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Core;

namespace Merge.Crm;

/// <summary>
/// # The MultipartFormField Object
/// ### Description
/// The `MultipartFormField` object is used to represent fields in an HTTP request using `multipart/form-data`.
///
/// ### Usage Example
/// Create a `MultipartFormField` to define a multipart form entry.
/// </summary>
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
    /// * `RAW` - RAW
    /// * `BASE64` - BASE64
    /// * `GZIP_BASE64` - GZIP_BASE64
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
