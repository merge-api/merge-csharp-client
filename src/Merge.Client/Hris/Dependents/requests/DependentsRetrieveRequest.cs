namespace Merge.Client.Hris;

public class DependentsRetrieveRequest
{
    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; init; }

    /// <summary>
    /// Whether to include sensitive fields (such as social security numbers) in the response.
    /// </summary>
    public bool? IncludeSensitiveFields { get; init; }
}
