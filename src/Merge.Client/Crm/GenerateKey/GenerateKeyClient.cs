using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Crm;

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
    /// <example>
    /// <code>
    /// await client.Crm.GenerateKey.CreateAsync(
    ///     new GenerateRemoteKeyRequest { Name = "Remote Deployment Key 1" }
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<RemoteKey> CreateAsync(
        GenerateRemoteKeyRequest request,
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
                    Path = "crm/v1/generate-key",
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
                return JsonUtils.Deserialize<RemoteKey>(responseBody)!;
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
