using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

public record DependentsRetrieveRequest
{
    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include sensitive fields (such as social security numbers) in the response.
    /// </summary>
    public bool? IncludeSensitiveFields { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
