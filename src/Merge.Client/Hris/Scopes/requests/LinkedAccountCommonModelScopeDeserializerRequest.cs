using Merge.Client.Hris;

namespace Merge.Client.Hris;

public class LinkedAccountCommonModelScopeDeserializerRequest
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    public List<IndividualCommonModelScopeDeserializerRequest> CommonModels { get; init; }
}
