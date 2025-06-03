using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

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
    private async Task<PaginatedAssociationList> CustomObjectClassesCustomObjectsAssociationsListInternalAsync(
        string customObjectClassId,
        string objectId,
        CustomObjectClassesCustomObjectsAssociationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["expand"] = request.Expand.Select(_value => _value.ToString()).ToList();
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
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = JsonUtils.Serialize(request.IncludeDeletedData.Value);
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = JsonUtils.Serialize(request.IncludeRemoteData.Value);
        }
        if (request.IncludeShellData != null)
        {
            _query["include_shell_data"] = JsonUtils.Serialize(request.IncludeShellData.Value);
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
            _query["page_size"] = request.PageSize.Value.ToString();
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "crm/v1/custom-object-classes/{0}/custom-objects/{1}/associations",
                        ValueConvert.ToPathParameterString(customObjectClassId),
                        ValueConvert.ToPathParameterString(objectId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<PaginatedAssociationList>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new MergeApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Returns a list of `Association` objects.
    /// </summary>
    /// <example><code>
    /// await client.Crm.Associations.CustomObjectClassesCustomObjectsAssociationsListAsync(
    ///     "custom_object_class_id",
    ///     "object_id",
    ///     new CustomObjectClassesCustomObjectsAssociationsListRequest()
    /// );
    /// </code></example>
    public async Task<Pager<Association>> CustomObjectClassesCustomObjectsAssociationsListAsync(
        string customObjectClassId,
        string objectId,
        CustomObjectClassesCustomObjectsAssociationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            CustomObjectClassesCustomObjectsAssociationsListRequest,
            RequestOptions?,
            PaginatedAssociationList,
            string?,
            Association
        >
            .CreateInstanceAsync(
                request,
                options,
                CustomObjectClassesCustomObjectsAssociationsListInternalAsync,
                (request, cursor) =>
                {
                    request.Cursor = cursor;
                },
                response => response?.Next,
                response => response?.Results?.ToList(),
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Creates an Association between `source_object_id` and `target_object_id` of type `association_type_id`.
    /// </summary>
    /// <example><code>
    /// await client.Crm.Associations.CustomObjectClassesCustomObjectsAssociationsUpdateAsync(
    ///     "association_type_id",
    ///     "source_class_id",
    ///     "source_object_id",
    ///     "target_class_id",
    ///     "target_object_id",
    ///     new CustomObjectClassesCustomObjectsAssociationsUpdateRequest()
    /// );
    /// </code></example>
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
            _query["is_debug_mode"] = JsonUtils.Serialize(request.IsDebugMode.Value);
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = JsonUtils.Serialize(request.RunAsync.Value);
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Put,
                    Path = string.Format(
                        "crm/v1/custom-object-classes/{0}/custom-objects/{1}/associations/{2}/{3}/{4}",
                        ValueConvert.ToPathParameterString(sourceClassId),
                        ValueConvert.ToPathParameterString(sourceObjectId),
                        ValueConvert.ToPathParameterString(targetClassId),
                        ValueConvert.ToPathParameterString(targetObjectId),
                        ValueConvert.ToPathParameterString(associationTypeId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Association>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new MergeApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
