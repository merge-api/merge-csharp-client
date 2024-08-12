using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record LinkedAccountCommonModelScopeDeserializerRequest
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    [JsonPropertyName("common_models")]
    public IEnumerable<IndividualCommonModelScopeDeserializerRequest> CommonModels { get; set; } =
        new List<IndividualCommonModelScopeDeserializerRequest>();
}
