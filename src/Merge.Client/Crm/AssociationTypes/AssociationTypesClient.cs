using System.Text.Json;
using Merge.Client;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class AssociationTypesClient
{
    private RawClient _client;

    public AssociationTypesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `AssociationType` objects.
    /// </summary>
    public async Task<PaginatedAssociationTypeList> CustomObjectClassesAssociationTypesListAsync(
        string customObjectClassId,
        CustomObjectClassesAssociationTypesListRequest request
    )
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
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/crm/v1/custom-object-classes/{customObjectClassId}/association-types",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedAssociationTypeList>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Creates an `AssociationType` object with the given values.
    /// </summary>
    public async Task<CrmAssociationTypeResponse> CustomObjectClassesAssociationTypesCreateAsync(
        string customObjectClassId,
        CrmAssociationTypeEndpointRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = request.IsDebugMode;
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = request.RunAsync;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/crm/v1/custom-object-classes/{customObjectClassId}/association-types",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CrmAssociationTypeResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns an `AssociationType` object with the given `id`.
    /// </summary>
    public async Task<AssociationType> CustomObjectClassesAssociationTypesRetrieveAsync(
        string customObjectClassId,
        string id,
        CustomObjectClassesAssociationTypesRetrieveRequest request
    )
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
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path =
                    $"/crm/v1/custom-object-classes/{customObjectClassId}/association-types/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AssociationType>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns metadata for `CRMAssociationType` POSTs.
    /// </summary>
    public async Task<MetaResponse> CustomObjectClassesAssociationTypesMetaPostRetrieveAsync(
        string customObjectClassId
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path =
                    $"/crm/v1/custom-object-classes/{customObjectClassId}/association-types/meta/post"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MetaResponse>(responseBody);
        }
        throw new Exception();
    }
}
