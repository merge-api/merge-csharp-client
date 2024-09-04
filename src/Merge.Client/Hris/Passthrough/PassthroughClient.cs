using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

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
    /// <example>
    /// <code>
    /// await client.Hris.Passthrough.CreateAsync(
    ///     new Merge.Client.Hris.DataPassthroughRequest
    ///     {
    ///         Method = Merge.Client.Hris.MethodEnum.Get,
    ///         Path = "/scooters",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<RemoteResponse> CreateAsync(
        DataPassthroughRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "hris/v1/passthrough",
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
                return JsonUtils.Deserialize<RemoteResponse>(responseBody)!;
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
