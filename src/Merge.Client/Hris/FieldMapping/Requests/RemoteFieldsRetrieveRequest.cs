using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[Serializable]
public record RemoteFieldsRetrieveRequest
{
    /// <summary>
    /// A comma seperated list of Common Model names. If included, will only return Remote Fields for those Common Models.
    /// </summary>
    [JsonIgnore]
    public string? CommonModels { get; set; }

    /// <summary>
    /// If true, will include example values, where available, for remote fields in the 3rd party platform. These examples come from active data from your customers.
    /// </summary>
    [JsonIgnore]
    public string? IncludeExampleValues { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
