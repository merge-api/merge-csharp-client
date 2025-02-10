using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record DataPassthroughRequest
{
    [JsonPropertyName("method")]
    public required MethodEnum Method { get; set; }

    /// <summary>
    /// The path of the request in the third party's platform.
    /// </summary>
    [JsonPropertyName("path")]
    public required string Path { get; set; }

    /// <summary>
    /// An optional override of the third party's base url for the request.
    /// </summary>
    [JsonPropertyName("base_url_override")]
    public string? BaseUrlOverride { get; set; }

    /// <summary>
    /// The data with the request. You must include a `request_format` parameter matching the data's format
    /// </summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>
    /// Pass an array of `MultipartFormField` objects in here instead of using the `data` param if `request_format` is set to `MULTIPART`.
    /// </summary>
    [JsonPropertyName("multipart_form_data")]
    public IEnumerable<MultipartFormFieldRequest>? MultipartFormData { get; set; }

    /// <summary>
    /// The headers to use for the request (Merge will handle the account's authorization headers). `Content-Type` header is required for passthrough. Choose content type corresponding to expected format of receiving server.
    /// </summary>
    [JsonPropertyName("headers")]
    public Dictionary<string, object?>? Headers { get; set; }

    [JsonPropertyName("request_format")]
    public RequestFormatEnum? RequestFormat { get; set; }

    /// <summary>
    /// Optional. If true, the response will always be an object of the form `{"type": T, "value": ...}` where `T` will be one of `string, boolean, number, null, array, object`.
    /// </summary>
    [JsonPropertyName("normalize_response")]
    public bool? NormalizeResponse { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
