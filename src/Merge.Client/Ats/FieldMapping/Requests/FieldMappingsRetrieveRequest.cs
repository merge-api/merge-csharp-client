using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record FieldMappingsRetrieveRequest
{
    /// <summary>
    /// If `true`, remote fields metadata is excluded from each field mapping instance (i.e. `remote_fields.remote_key_name` and `remote_fields.schema` will be null). This will increase the speed of the request since these fields require some calculations.
    /// </summary>
    public bool? ExcludeRemoteFieldMetadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
