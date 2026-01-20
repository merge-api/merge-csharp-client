using Merge.Client.Core;

namespace Merge.Client.Hris;

[Serializable]
public record FieldMappingsDestroyRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
