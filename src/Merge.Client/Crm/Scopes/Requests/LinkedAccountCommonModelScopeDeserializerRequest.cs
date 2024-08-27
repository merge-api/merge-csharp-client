using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

public record LinkedAccountCommonModelScopeDeserializerRequest
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    [JsonPropertyName("common_models")]
    public IEnumerable<IndividualCommonModelScopeDeserializerRequest> CommonModels { get; set; } =
        new List<IndividualCommonModelScopeDeserializerRequest>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
