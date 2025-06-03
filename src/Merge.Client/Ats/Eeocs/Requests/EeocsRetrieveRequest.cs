using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public record EeocsRetrieveRequest
{
    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> Expand { get; set; } = new List<string>();

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include shell records. Shell records are empty records (they may contain some metadata but all other fields are null).
    /// </summary>
    [JsonIgnore]
    public bool? IncludeShellData { get; set; }

    /// <summary>
    /// Deprecated. Use show_enum_origins.
    /// </summary>
    [JsonIgnore]
    public EeocsRetrieveRequestRemoteFields? RemoteFields { get; set; }

    /// <summary>
    /// A comma separated list of enum field names for which you'd like the original values to be returned, instead of Merge's normalized enum values. [Learn more](https://help.merge.dev/en/articles/8950958-show_enum_origins-query-parameter)
    /// </summary>
    [JsonIgnore]
    public EeocsRetrieveRequestShowEnumOrigins? ShowEnumOrigins { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
