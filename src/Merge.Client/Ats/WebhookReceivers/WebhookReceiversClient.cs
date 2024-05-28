using System.Text.Json;
using Merge.Client;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class WebhookReceiversClient
{
    private RawClient _client;

    public WebhookReceiversClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `WebhookReceiver` objects.
    /// </summary>
    public async Task<List<WebhookReceiver>> ListAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/ats/v1/webhook-receivers" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<List<WebhookReceiver>>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Creates a `WebhookReceiver` object with the given values.
    /// </summary>
    public async Task<WebhookReceiver> CreateAsync(WebhookReceiverRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/ats/v1/webhook-receivers",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<WebhookReceiver>(responseBody);
        }
        throw new Exception();
    }
}
