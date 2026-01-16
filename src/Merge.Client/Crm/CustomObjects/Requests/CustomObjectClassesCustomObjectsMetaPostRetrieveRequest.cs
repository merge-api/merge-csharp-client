using Merge.Client.Core;

namespace Merge.Client.Crm;

[Serializable]
public record CustomObjectClassesCustomObjectsMetaPostRetrieveRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
