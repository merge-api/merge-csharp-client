using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

public partial class PhoneNumbersClient
{
    private RawClient _client;

    internal PhoneNumbersClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns an `AccountingPhoneNumber` object with the given `id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Accounting.PhoneNumbers.RetrieveAsync("id", new PhoneNumbersRetrieveRequest());
    /// </code>
    /// </example>
    public async Task<AccountingPhoneNumber> RetrieveAsync(
        string id,
        PhoneNumbersRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"accounting/v1/phone-numbers/{id}",
                Query = _query,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<AccountingPhoneNumber>(responseBody)!;
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
