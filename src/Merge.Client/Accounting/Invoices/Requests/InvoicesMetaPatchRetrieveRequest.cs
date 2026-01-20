using Merge.Client.Core;

namespace Merge.Client.Accounting;

[Serializable]
public record InvoicesMetaPatchRetrieveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
