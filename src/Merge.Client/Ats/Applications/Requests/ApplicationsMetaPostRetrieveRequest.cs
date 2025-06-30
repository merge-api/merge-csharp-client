using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[Serializable]
public record ApplicationsMetaPostRetrieveRequest
{
    /// <summary>
    /// The template ID associated with the nested application in the request.
    /// </summary>
    [JsonIgnore]
    public string? ApplicationRemoteTemplateId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
