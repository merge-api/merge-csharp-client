using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

public partial class AddressesClient
{
    private RawClient _client;

    internal AddressesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns an `Address` object with the given `id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Accounting.Addresses.RetrieveAsync("id", new AddressesRetrieveRequest());
    /// </code>
    /// </example>
    public async Task<Address> RetrieveAsync(
        string id,
        AddressesRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields.ToString();
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"accounting/v1/addresses/{id}",
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
                return JsonUtils.Deserialize<Address>(responseBody)!;
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
