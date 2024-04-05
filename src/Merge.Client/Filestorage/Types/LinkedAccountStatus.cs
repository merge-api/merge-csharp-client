using System.Text.Json.Serialization;

namespace Merge.Client.Filestorage;

public class LinkedAccountStatus
{
    [JsonPropertyName("linked_account_status")]
    public string LinkedAccountStatus_ { get; init; }

    [JsonPropertyName("can_make_request")]
    public bool CanMakeRequest { get; init; }
}
