using Merge.Client.Core;

namespace Merge.Client.Accounting;

[Serializable]
public record IssuesRetrieveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
