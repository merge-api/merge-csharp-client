using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

namespace Merge.Client.Filestorage;

public class AccountToken
{
    [JsonPropertyName("account_token")]
    public string AccountToken_ { get; init; }

    [JsonPropertyName("integration")]
    public AccountIntegration Integration { get; init; }
}
