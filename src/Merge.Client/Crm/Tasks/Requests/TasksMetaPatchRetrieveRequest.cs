using Merge.Client.Core;

namespace Merge.Client.Crm;

[Serializable]
public record TasksMetaPatchRetrieveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
