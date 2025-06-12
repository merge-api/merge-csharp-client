using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public partial class PassthroughClient
{
    private RawClient _client;

    internal PassthroughClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Pull data from an endpoint not currently supported by Merge.
    /// </summary>
    /// <example><code>
    /// await client.Ats.Passthrough.CreateAsync(
    ///     new Merge.Client.Ats.DataPassthroughRequest
    ///     {
    ///         Method = Merge.Client.Ats.MethodEnum.Get,
    ///         Path = "/scooters",
    ///     }
    /// );
    /// </code></example>
    public async Task<RemoteResponse> CreateAsync(
        DataPassthroughRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "ats/v1/passthrough",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<RemoteResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new MergeApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
