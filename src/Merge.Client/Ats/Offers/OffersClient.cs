using System.Text.Json;
using Merge.Client;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class OffersClient
{
    private RawClient _client;

    public OffersClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Offer` objects.
    /// </summary>
    public async Task<PaginatedOfferList> ListAsync(OffersListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.ApplicationId != null)
        {
            _query["application_id"] = request.ApplicationId;
        }
        if (request.CreatedAfter != null)
        {
            _query["created_after"] = request.CreatedAfter;
        }
        if (request.CreatedBefore != null)
        {
            _query["created_before"] = request.CreatedBefore;
        }
        if (request.CreatorId != null)
        {
            _query["creator_id"] = request.CreatorId;
        }
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData;
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.ModifiedAfter != null)
        {
            _query["modified_after"] = request.ModifiedAfter;
        }
        if (request.ModifiedBefore != null)
        {
            _query["modified_before"] = request.ModifiedBefore;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields;
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/ats/v1/offers",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedOfferList>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns an `Offer` object with the given `id`.
    /// </summary>
    public async Task<Offer> RetrieveAsync(string id, OffersRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand;
        }
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
                Path = $"/ats/v1/offers/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Offer>(responseBody);
        }
        throw new Exception();
    }
}
