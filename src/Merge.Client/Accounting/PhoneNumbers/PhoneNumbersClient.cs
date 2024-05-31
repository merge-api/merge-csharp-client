using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class PhoneNumbersClient
{
    private RawClient _client;

    public PhoneNumbersClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns an `AccountingPhoneNumber` object with the given `id`.
    /// </summary>
    public async Task<AccountingPhoneNumber> RetrieveAsync(
        string id,
        PhoneNumbersRetrieveRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/accounting/v1/phone-numbers/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AccountingPhoneNumber>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
