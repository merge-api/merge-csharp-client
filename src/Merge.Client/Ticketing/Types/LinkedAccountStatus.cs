using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public record LinkedAccountStatus
{
    [JsonPropertyName("linked_account_status")]
    public required string LinkedAccountStatus_ { get; set; }

    [JsonPropertyName("can_make_request")]
    public required bool CanMakeRequest { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
