using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Crm;

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
    /// await client.Crm.Passthrough.CreateAsync(
    ///     new Merge.Client.Crm.DataPassthroughRequest
    ///     {
    ///         Method = Merge.Client.Crm.MethodEnum.Get,
    ///         Path = "/scooters",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<RemoteResponse> CreateAsync(
        DataPassthroughRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "crm/v1/passthrough",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
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
