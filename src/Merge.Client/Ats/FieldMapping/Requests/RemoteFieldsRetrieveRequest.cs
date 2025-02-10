using Merge.Client.Core;

namespace Merge.Client.Ats;

public record RemoteFieldsRetrieveRequest
{
    /// <summary>
    /// A comma seperated list of Common Model names. If included, will only return Remote Fields for those Common Models.
    /// </summary>
    public string? CommonModels { get; set; }

    /// <summary>
    /// If true, will include example values, where available, for remote fields in the 3rd party platform. These examples come from active data from your customers.
    /// </summary>
    public string? IncludeExampleValues { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
