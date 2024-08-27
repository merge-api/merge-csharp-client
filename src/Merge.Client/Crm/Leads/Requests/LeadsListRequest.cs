using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

public record LeadsListRequest
{
    /// <summary>
    /// If provided, will only return leads with this account.
    /// </summary>
    public string? ConvertedAccountId { get; set; }

    /// <summary>
    /// If provided, will only return leads with this contact.
    /// </summary>
    public string? ConvertedContactId { get; set; }

    /// <summary>
    /// If provided, will only return objects created after this datetime.
    /// </summary>
    public DateTime? CreatedAfter { get; set; }

    /// <summary>
    /// If provided, will only return objects created before this datetime.
    /// </summary>
    public DateTime? CreatedBefore { get; set; }

    /// <summary>
    /// The pagination cursor value.
    /// </summary>
    public string? Cursor { get; set; }

    /// <summary>
    /// If provided, will only return contacts matching the email addresses; multiple email_addresses can be separated by commas.
    /// </summary>
    public string? EmailAddresses { get; set; }

    /// <summary>
    /// Which relations should be returned in expanded form. Multiple relation names should be comma separated without spaces.
    /// </summary>
    public LeadsListRequestExpand? Expand { get; set; }

    /// <summary>
    /// Whether to include data that was marked as deleted by third party webhooks.
    /// </summary>
    public bool? IncludeDeletedData { get; set; }

    /// <summary>
    /// Whether to include the original data Merge fetched from the third-party to produce these models.
    /// </summary>
    public bool? IncludeRemoteData { get; set; }

    /// <summary>
    /// Whether to include all remote fields, including fields that Merge did not map to common models, in a normalized format.
    /// </summary>
    public bool? IncludeRemoteFields { get; set; }

    /// <summary>
    /// If provided, only objects synced by Merge after this date time will be returned.
    /// </summary>
    public DateTime? ModifiedAfter { get; set; }

    /// <summary>
    /// If provided, only objects synced by Merge before this date time will be returned.
    /// </summary>
    public DateTime? ModifiedBefore { get; set; }

    /// <summary>
    /// If provided, will only return leads with this owner.
    /// </summary>
    public string? OwnerId { get; set; }

    /// <summary>
    /// Number of results to return per page.
    /// </summary>
    public int? PageSize { get; set; }

    /// <summary>
    /// If provided, will only return contacts matching the phone numbers; multiple phone numbers can be separated by commas.
    /// </summary>
    public string? PhoneNumbers { get; set; }

    /// <summary>
    /// The API provider's ID for the given object.
    /// </summary>
    public string? RemoteId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
