using Merge.Client.Core;

namespace Merge.Client.Accounting;

[Serializable]
public record AsyncTasksRetrieveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
