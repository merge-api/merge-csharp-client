using System.Text.Json.Serialization;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class AccountToken
{
    [JsonPropertyName("account_token")]
    public string AccountToken_ { get; init; }

    [JsonPropertyName("integration")]
    public AccountIntegration Integration { get; init; }
}
