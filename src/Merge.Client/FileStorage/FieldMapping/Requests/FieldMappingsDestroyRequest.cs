using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[Serializable]
public record FieldMappingsDestroyRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
