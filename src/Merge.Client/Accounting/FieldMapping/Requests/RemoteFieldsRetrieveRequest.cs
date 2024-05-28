namespace Merge.Client.Accounting;

public class RemoteFieldsRetrieveRequest
{
    /// <summary>
    /// A comma seperated list of Common Model names. If included, will only return Remote Fields for those Common Models.
    /// </summary>
    public string? CommonModels { get; init; }

    /// <summary>
    /// If true, will include example values, where available, for remote fields in the 3rd party platform. These examples come from active data from your customers.
    /// </summary>
    public string? IncludeExampleValues { get; init; }
}
