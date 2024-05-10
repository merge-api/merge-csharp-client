using System.Text.Json;
using Merge.Client;
using Merge.Client.Crm;

namespace Merge.Client.Crm;

public class AssociationsClient
{
    private RawClient _client;

    public AssociationsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Association` objects.
    /// </summary>
    public async Task<PaginatedAssociationList> CustomObjectClassesCustomObjectsAssociationsListAsync(
        string customObjectClassId,
        string objectId,
        CustomObjectClassesCustomObjectsAssociationsListRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.AssociationTypeId != null)
        {
            _query["association_type_id"] = request.AssociationTypeId;
        }
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
                Path =
                    $"/crm/v1/custom-object-classes/{customObjectClassId}/custom-objects/{objectId}/associations",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedAssociationList>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Creates an Association between `source_object_id` and `target_object_id` of type `association_type_id`.
    /// </summary>
    public async Task<Association> CustomObjectClassesCustomObjectsAssociationsUpdateAsync(
        string associationTypeId,
        string sourceClassId,
        string sourceObjectId,
        string targetClassId,
        string targetObjectId,
        CustomObjectClassesCustomObjectsAssociationsUpdateRequest request
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
                Method = HttpMethod.Put,
                Path =
                    $"/crm/v1/custom-object-classes/{sourceClassId}/custom-objects/{sourceObjectId}/associations/{targetClassId}/{targetObjectId}/{associationTypeId}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Association>(responseBody);
        }
        throw new Exception();
    }
}
