using System.Text.Json.Serialization;
using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class DataPassthroughRequest
{
    [JsonPropertyName("method")]
    public MethodEnum Method { get; init; }

    [JsonPropertyName("path")]
    public string Path { get; init; }

    [JsonPropertyName("base_url_override")]
    public string? BaseUrlOverride { get; init; }

    [JsonPropertyName("data")]
    public string? Data { get; init; }

    /// <summary>
    /// Pass an array of `MultipartFormField` objects in here instead of using the `data` param if `request_format` is set to `MULTIPART`.
    /// </summary>
    [JsonPropertyName("multipart_form_data")]
    public List<MultipartFormFieldRequest>? MultipartFormData { get; init; }

    /// <summary>
    /// The headers to use for the request (Merge will handle the account's authorization headers). `Content-Type` header is required for passthrough. Choose content type corresponding to expected format of receiving server.
    /// </summary>
    [JsonPropertyName("headers")]
    public Dictionary<string, object>? Headers { get; init; }

    [JsonPropertyName("request_format")]
    public RequestFormatEnum? RequestFormat { get; init; }

    /// <summary>
    /// Optional. If true, the response will always be an object of the form `{"type": T, "value": ...}` where `T` will be one of `string, boolean, number, null, array, object`.
    /// </summary>
    [JsonPropertyName("normalize_response")]
    public bool? NormalizeResponse { get; init; }
}
