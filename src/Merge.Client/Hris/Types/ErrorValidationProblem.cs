using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record ErrorValidationProblem
{
    [JsonPropertyName("source")]
    public ValidationProblemSource? Source { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("detail")]
    public required string Detail { get; set; }

    [JsonPropertyName("problem_type")]
    public required string ProblemType { get; set; }

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
