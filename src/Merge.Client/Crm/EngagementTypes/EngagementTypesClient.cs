using System.Text.Json;
using Merge.Client;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class EngagementTypesClient
{
    private RawClient _client;

    public EngagementTypesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `EngagementType` objects.
    /// </summary>
    public async Task<PaginatedEngagementTypeList> ListAsync(EngagementTypesListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.CreatedAfter != null)
        {
            _query["created_after"] = request.CreatedAfter;
        }
        if (request.CreatedBefore != null)
        {
            _query["created_before"] = request.CreatedBefore;
        }
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData;
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.IncludeRemoteFields != null)
        {
            _query["include_remote_fields"] = request.IncludeRemoteFields;
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
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/crm/v1/engagement-types",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedEngagementTypeList>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns an `EngagementType` object with the given `id`.
    /// </summary>
    public async Task<EngagementType> RetrieveAsync(
        string id,
        EngagementTypesRetrieveRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.IncludeRemoteFields != null)
        {
            _query["include_remote_fields"] = request.IncludeRemoteFields;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/crm/v1/engagement-types/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EngagementType>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns a list of `RemoteFieldClass` objects.
    /// </summary>
    public async Task<PaginatedRemoteFieldClassList> RemoteFieldClassesListAsync(
        EngagementTypesRemoteFieldClassesListRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData;
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.IncludeRemoteFields != null)
        {
            _query["include_remote_fields"] = request.IncludeRemoteFields;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/crm/v1/engagement-types/remote-field-classes",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedRemoteFieldClassList>(responseBody);
        }
        throw new Exception();
    }
}
