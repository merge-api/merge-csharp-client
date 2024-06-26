using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class AvailableActionsClient
{
    private RawClient _client;

    public AvailableActionsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of models and actions available for an account.
    /// </summary>
    public async Task<AvailableActions> RetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "accounting/v1/available-actions"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AvailableActions>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
