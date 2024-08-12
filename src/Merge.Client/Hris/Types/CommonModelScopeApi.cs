using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public record CommonModelScopeApi
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    [JsonPropertyName("common_models")]
    public IEnumerable<IndividualCommonModelScopeDeserializer> CommonModels { get; set; } =
        new List<IndividualCommonModelScopeDeserializer>();
}
