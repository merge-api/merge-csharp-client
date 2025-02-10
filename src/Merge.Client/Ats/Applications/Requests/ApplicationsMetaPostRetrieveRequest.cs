using Merge.Client.Core;

namespace Merge.Client.Ats;

public record ApplicationsMetaPostRetrieveRequest
{
    /// <summary>
    /// The template ID associated with the nested application in the request.
    /// </summary>
    public string? ApplicationRemoteTemplateId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
