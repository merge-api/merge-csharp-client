using Merge.Client.Core;

namespace Merge.Client.Ats;

[Serializable]
public record AccountTokenRetrieveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
