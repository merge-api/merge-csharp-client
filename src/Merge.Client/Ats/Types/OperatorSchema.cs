using System.Text.Json.Serialization;

namespace Merge.Client.Ats;

public class OperatorSchema
{
    /// <summary>
    /// The operator for which an operator schema is defined.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; init; }

    /// <summary>
    /// Whether the operator can be repeated multiple times.
    /// </summary>
    [JsonPropertyName("is_unique")]
    public bool? IsUnique { get; init; }
}
