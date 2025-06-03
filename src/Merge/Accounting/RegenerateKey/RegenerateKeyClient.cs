using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge;
using Merge.Core;

namespace Merge.Accounting.RegenerateKey;

public partial class RegenerateKeyClient
{
    private RawClient _client;

    internal RegenerateKeyClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Exchange remote keys.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.RegenerateKey.CreateAsync(
    ///     new RemoteKeyForRegenerationRequest { Name = "Remote Deployment Key 1" }
    /// );
    /// </code></example>
    public async Task<RemoteKey> CreateAsync(
        RemoteKeyForRegenerationRequest request,
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
                            Path = "accounting/v1/regenerate-key",
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
