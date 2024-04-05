using System.Text.Json.Serialization;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class AccountToken
{
    [JsonPropertyName("account_token")]
    public string AccountToken_ { get; init; }

    [JsonPropertyName("integration")]
    public AccountIntegration Integration { get; init; }
}
