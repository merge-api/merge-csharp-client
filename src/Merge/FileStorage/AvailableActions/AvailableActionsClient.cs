using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge;
using Merge.Core;

namespace Merge.FileStorage.AvailableActions;

public partial class AvailableActionsClient
{
    private RawClient _client;

    internal AvailableActionsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of models and actions available for an account.
    /// </summary>
    /// <example><code>
    /// await client.FileStorage.AvailableActions.RetrieveAsync();
    /// </code></example>
    public async Task<Merge.FileStorage.AvailableActions> RetrieveAsync(
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
                            Method = HttpMethod.Get,
                            Path = "filestorage/v1/available-actions",
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
                        return JsonUtils.Deserialize<Merge.FileStorage.AvailableActions>(
                            responseBody
                        )!;
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
