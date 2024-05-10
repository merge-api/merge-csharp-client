using System.Text.Json.Serialization;
using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class CommonModelScopeApi
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    [JsonPropertyName("common_models")]
    public List<IndividualCommonModelScopeDeserializer> CommonModels { get; init; }
}
