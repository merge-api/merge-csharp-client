using System.Text.Json.Serialization;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class PaginatedEmployerBenefitList
{
    [JsonPropertyName("next")]
    public string? Next { get; init; }

    [JsonPropertyName("previous")]
    public string? Previous { get; init; }

    [JsonPropertyName("results")]
    public List<EmployerBenefit>? Results { get; init; }
}
