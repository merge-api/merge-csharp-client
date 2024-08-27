using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Filestorage;

public partial class WebhookReceiversClient
{
    private RawClient _client;

    internal WebhookReceiversClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `WebhookReceiver` objects.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Filestorage.WebhookReceivers.ListAsync();
    /// </code>
    /// </example>
    public async Task<IEnumerable<WebhookReceiver>> ListAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "filestorage/v1/webhook-receivers",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<WebhookReceiver>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Creates a `WebhookReceiver` object with the given values.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Filestorage.WebhookReceivers.CreateAsync(
    ///     new WebhookReceiverRequest { Event = "event", IsActive = true }
    /// );
    /// </code>
    /// </example>
    public async Task<WebhookReceiver> CreateAsync(
        WebhookReceiverRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "filestorage/v1/webhook-receivers",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<WebhookReceiver>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
