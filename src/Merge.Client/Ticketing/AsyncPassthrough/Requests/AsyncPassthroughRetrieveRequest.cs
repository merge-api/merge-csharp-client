using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[Serializable]
public record AsyncPassthroughRetrieveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
