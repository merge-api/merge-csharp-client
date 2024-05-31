using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class LinkedAccountCommonModelScopeDeserializerRequest
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    [JsonPropertyName("common_models")]
    public IEnumerable<IndividualCommonModelScopeDeserializerRequest> CommonModels { get; init; }
}
