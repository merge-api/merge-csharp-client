using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class LinkedAccountCommonModelScopeDeserializerRequest
{
    /// <summary>
    /// The common models you want to update the scopes for
    /// </summary>
    public List<IndividualCommonModelScopeDeserializerRequest> CommonModels { get; init; }
}
