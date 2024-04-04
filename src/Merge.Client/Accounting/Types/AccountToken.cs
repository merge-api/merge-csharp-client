using System.Text.Json.Serialization;
using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class AccountToken
{
    [JsonPropertyName("account_token")]
    public string AccountToken { get; init; }

    [JsonPropertyName("integration")]
    public AccountIntegration Integration { get; init; }
}
