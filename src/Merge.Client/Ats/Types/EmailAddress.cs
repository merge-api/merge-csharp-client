using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public record EmailAddress
{
    /// <summary>
    /// The datetime that this object was created by Merge.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// The datetime that this object was modified by Merge.
    /// </summary>
    [JsonPropertyName("modified_at")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// The email address.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// The type of email address.
    ///
    /// - `PERSONAL` - PERSONAL
    /// - `WORK` - WORK
    /// - `OTHER` - OTHER
    /// </summary>
    [JsonPropertyName("email_address_type")]
    public EmailAddressTypeEnum? EmailAddressType { get; set; }

    /// <summary>
    /// Indicates whether or not this object has been deleted in the third party platform.
    /// </summary>
    [JsonPropertyName("remote_was_deleted")]
    public bool? RemoteWasDeleted { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
