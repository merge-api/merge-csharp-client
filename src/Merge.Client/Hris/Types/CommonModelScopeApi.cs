using System.Text.Json.Serialization;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class CommonModelScopeApi
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    [JsonPropertyName("common_models")]
    public IEnumerable<IndividualCommonModelScopeDeserializer> CommonModels { get; init; }
}
