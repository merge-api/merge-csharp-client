using System.Text.Json.Serialization;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class AccountToken
{
    [JsonPropertyName("account_token")]
    public string AccountToken { get; init; }

    [JsonPropertyName("integration")]
    public AccountIntegration Integration { get; init; }
}
