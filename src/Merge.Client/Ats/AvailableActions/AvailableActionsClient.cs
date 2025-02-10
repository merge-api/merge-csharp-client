using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Ats;

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
    /// <example>
    /// <code>
    /// await client.Ats.AvailableActions.RetrieveAsync();
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<AvailableActions> RetrieveAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "ats/v1/available-actions",
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
                return JsonUtils.Deserialize<AvailableActions>(responseBody)!;
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
