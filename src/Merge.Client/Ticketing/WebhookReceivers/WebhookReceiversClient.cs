using System.Text.Json;
using Merge.Client;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

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
    public async Task<IEnumerable<WebhookReceiver>> ListAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "ticketing/v1/webhook-receivers"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<WebhookReceiver>>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a `WebhookReceiver` object with the given values.
    /// </summary>
    public async Task<WebhookReceiver> CreateAsync(WebhookReceiverRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "ticketing/v1/webhook-receivers",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<WebhookReceiver>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
