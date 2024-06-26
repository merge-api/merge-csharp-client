using System.Text.Json;
using Merge.Client;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class CustomObjectsClient
{
    private RawClient _client;

    public CustomObjectsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `CustomObject` objects.
    /// </summary>
    public async Task<PaginatedCustomObjectList> CustomObjectClassesCustomObjectsListAsync(
        string customObjectClassId,
        CustomObjectClassesCustomObjectsListRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.CreatedAfter != null)
        {
            _query["created_after"] = request.CreatedAfter.Value.ToString("o0");
        }
        if (request.CreatedBefore != null)
        {
            _query["created_before"] = request.CreatedBefore.Value.ToString("o0");
        }
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData.ToString();
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        if (request.IncludeRemoteFields != null)
        {
            _query["include_remote_fields"] = request.IncludeRemoteFields.ToString();
        }
        if (request.ModifiedAfter != null)
        {
            _query["modified_after"] = request.ModifiedAfter.Value.ToString("o0");
        }
        if (request.ModifiedBefore != null)
        {
            _query["modified_before"] = request.ModifiedBefore.Value.ToString("o0");
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.ToString();
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/crm/v1/custom-object-classes/{customObjectClassId}/custom-objects",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedCustomObjectList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a `CustomObject` object with the given values.
    /// </summary>
    public async Task<CrmCustomObjectResponse> CustomObjectClassesCustomObjectsCreateAsync(
        string customObjectClassId,
        CrmCustomObjectEndpointRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = request.IsDebugMode.ToString();
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = request.RunAsync.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/crm/v1/custom-object-classes/{customObjectClassId}/custom-objects",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CrmCustomObjectResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a `CustomObject` object with the given `id`.
    /// </summary>
    public async Task<CustomObject> CustomObjectClassesCustomObjectsRetrieveAsync(
        string customObjectClassId,
        string id,
        CustomObjectClassesCustomObjectsRetrieveRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        if (request.IncludeRemoteFields != null)
        {
            _query["include_remote_fields"] = request.IncludeRemoteFields.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/crm/v1/custom-object-classes/{customObjectClassId}/custom-objects/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CustomObject>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns metadata for `CRMCustomObject` POSTs.
    /// </summary>
    public async Task<MetaResponse> CustomObjectClassesCustomObjectsMetaPostRetrieveAsync(
        string customObjectClassId
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path =
                    $"/crm/v1/custom-object-classes/{customObjectClassId}/custom-objects/meta/post"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MetaResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
