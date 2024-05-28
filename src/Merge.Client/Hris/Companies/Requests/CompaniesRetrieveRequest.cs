namespace Merge.Client.Hris;

public class CompaniesRetrieveRequest
{
    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; init; }
}
