using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class AddressesClient
{
    private RawClient _client;

    public AddressesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns an `Address` object with the given `id`.
    /// </summary>
    public async Task<Address> RetrieveAsync(string id, AddressesRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields;
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/accounting/v1/addresses/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Address>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
