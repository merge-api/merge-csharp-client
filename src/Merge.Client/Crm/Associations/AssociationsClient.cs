using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

public partial class AssociationsClient
{
    private RawClient _client;

    internal AssociationsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Association` objects.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.Associations.CustomObjectClassesCustomObjectsAssociationsListAsync(
    ///     "custom_object_class_id",
    ///     "object_id",
    ///     new CustomObjectClassesCustomObjectsAssociationsListRequest()
    /// );
    /// </code>
    /// </example>
    public async Task<PaginatedAssociationList> CustomObjectClassesCustomObjectsAssociationsListAsync(
        string customObjectClassId,
        string objectId,
        CustomObjectClassesCustomObjectsAssociationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.AssociationTypeId != null)
        {
            _query["association_type_id"] = request.AssociationTypeId;
        }
        if (request.CreatedAfter != null)
        {
            _query["created_after"] = request.CreatedAfter.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.CreatedBefore != null)
        {
            _query["created_before"] = request.CreatedBefore.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand.ToString();
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData.ToString();
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        if (request.ModifiedAfter != null)
        {
            _query["modified_after"] = request.ModifiedAfter.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.ModifiedBefore != null)
        {
            _query["modified_before"] = request.ModifiedBefore.Value.ToString(
                Constants.DateTimeFormat
            );
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
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path =
                    $"crm/v1/custom-object-classes/{customObjectClassId}/custom-objects/{objectId}/associations",
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
                return JsonUtils.Deserialize<PaginatedAssociationList>(responseBody)!;
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

    /// <summary>
    /// Creates an Association between `source_object_id` and `target_object_id` of type `association_type_id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.Associations.CustomObjectClassesCustomObjectsAssociationsUpdateAsync(
    ///     "association_type_id",
    ///     "source_class_id",
    ///     "source_object_id",
    ///     "target_class_id",
    ///     "target_object_id",
    ///     new CustomObjectClassesCustomObjectsAssociationsUpdateRequest()
    /// );
    /// </code>
    /// </example>
    public async Task<Association> CustomObjectClassesCustomObjectsAssociationsUpdateAsync(
        string associationTypeId,
        string sourceClassId,
        string sourceObjectId,
        string targetClassId,
        string targetObjectId,
        CustomObjectClassesCustomObjectsAssociationsUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = request.IsDebugMode.ToString();
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = request.RunAsync.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Put,
                Path =
                    $"crm/v1/custom-object-classes/{sourceClassId}/custom-objects/{sourceObjectId}/associations/{targetClassId}/{targetObjectId}/{associationTypeId}",
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
                return JsonUtils.Deserialize<Association>(responseBody)!;
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
