using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public record LinkedAccountStatus
{
    [JsonPropertyName("linked_account_status")]
    public required string LinkedAccountStatus_ { get; set; }

    [JsonPropertyName("can_make_request")]
    public required bool CanMakeRequest { get; set; }
}
