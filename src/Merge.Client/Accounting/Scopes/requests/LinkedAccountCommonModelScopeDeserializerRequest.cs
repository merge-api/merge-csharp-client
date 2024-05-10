using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class LinkedAccountCommonModelScopeDeserializerRequest
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    public List<IndividualCommonModelScopeDeserializerRequest> CommonModels { get; init; }
}
