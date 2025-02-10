using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public record CommonModelScopeApi
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    [JsonPropertyName("common_models")]
    public IEnumerable<IndividualCommonModelScopeDeserializer> CommonModels { get; set; } =
        new List<IndividualCommonModelScopeDeserializer>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
