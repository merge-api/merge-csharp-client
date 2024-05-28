using System.Text.Json.Serialization;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class AccountToken
{
    [JsonPropertyName("account_token")]
    public string AccountToken_ { get; init; }

    [JsonPropertyName("integration")]
    public AccountIntegration Integration { get; init; }
}
