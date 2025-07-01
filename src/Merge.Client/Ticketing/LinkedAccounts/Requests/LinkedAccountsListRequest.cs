using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

[Serializable]
public record LinkedAccountsListRequest
{
    /// <summary>
    /// Options: `accounting`, `ats`, `crm`, `filestorage`, `hris`, `mktg`, `ticketing`
    ///
    /// * `hris` - hris
    /// * `ats` - ats
    /// * `accounting` - accounting
    /// * `ticketing` - ticketing
    /// * `crm` - crm
    /// * `mktg` - mktg
    /// * `filestorage` - filestorage
    /// </summary>
    [JsonIgnore]
    public LinkedAccountsListRequestCategory? Category { get; set; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    [JsonIgnore]
    public string? Cursor { get; set; }

    /// <summary>
    /// If provided, will only return linked accounts associated with the given email address.
    /// </summary>
    [JsonIgnore]
    public string? EndUserEmailAddress { get; set; }

    /// <summary>
    /// If provided, will only return linked accounts associated with the given organization name.
    /// </summary>
    [JsonIgnore]
    public string? EndUserOrganizationName { get; set; }

    /// <summary>
    /// If provided, will only return linked accounts associated with the given origin ID.
    /// </summary>
    [JsonIgnore]
    public string? EndUserOriginId { get; set; }

    /// <summary>
    /// Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once.
    /// </summary>
    [JsonIgnore]
    public string? EndUserOriginIds { get; set; }

    [JsonIgnore]
    public string? Id { get; set; }

    /// <summary>
    /// Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once.
    /// </summary>
    [JsonIgnore]
    public string? Ids { get; set; }

    /// <summary>
    /// If `true`, will include complete production duplicates of the account specified by the `id` query parameter in the response. `id` must be for a complete production linked account.
    /// </summary>
    [JsonIgnore]
    public bool? IncludeDuplicates { get; set; }

    /// <summary>
    /// If provided, will only return linked accounts associated with the given integration name.
    /// </summary>
    [JsonIgnore]
    public string? IntegrationName { get; set; }

    /// <summary>
    /// If included, will only include test linked accounts. If not included, will only include non-test linked accounts.
    /// </summary>
    [JsonIgnore]
    public string? IsTestAccount { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    [JsonIgnore]
    public int? PageSize { get; set; }

    /// <summary>
    /// Filter by status. Options: `COMPLETE`, `IDLE`, `INCOMPLETE`, `RELINK_NEEDED`
    /// </summary>
    [JsonIgnore]
    public string? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
