using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge;
using Merge.Core;

namespace Merge.Ticketing.GenerateKey;

public partial class GenerateKeyClient
{
    private RawClient _client;

    internal GenerateKeyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Create a remote key.
    /// </summary>
    /// <example><code>
    /// await client.Ticketing.GenerateKey.CreateAsync(
    ///     new GenerateRemoteKeyRequest { Name = "Remote Deployment Key 1" }
    /// );
    /// </code></example>
    public async Task<RemoteKey> CreateAsync(
        GenerateRemoteKeyRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Post,
                            Path = "ticketing/v1/generate-key",
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
                        return JsonUtils.Deserialize<RemoteKey>(responseBody)!;
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
            })
            .ConfigureAwait(false);
    }
}
