using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[Serializable]
public record EngagementsRemoteFieldClassesListRequest
{
    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    [JsonIgnore]
    public string? Cursor { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform. Full coverage deletion detection is a premium add-on. Native deletion detection is offered for free with limited coverage. [Learn more](https://docs.merge.dev/integrations/hris/supported-features/).
    /// </summary>
    [JsonIgnore]
    public bool? IncludeDeletedData { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeRemoteFields { get; set; }

    /// <summary>
    /// Whether to include shell records. Shell records are empty records (they may contain some metadata but all other fields are null).
    /// </summary>
    [JsonIgnore]
    public bool? IncludeShellData { get; set; }

    /// <summary>
    /// If provided, will only return remote field classes with this is_common_model_field value
    /// </summary>
    [JsonIgnore]
    public bool? IsCommonModelField { get; set; }

    /// <summary>
    /// If provided, will only return remote fields classes with this is_custom value
    /// </summary>
    [JsonIgnore]
    public bool? IsCustom { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    [JsonIgnore]
    public int? PageSize { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
