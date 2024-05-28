using System.Text.Json.Serialization;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class CommonModelScopeApi
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    [JsonPropertyName("common_models")]
    public List<IndividualCommonModelScopeDeserializer> CommonModels { get; init; }
}
