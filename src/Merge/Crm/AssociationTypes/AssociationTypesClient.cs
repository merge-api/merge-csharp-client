using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge;
using Merge.Core;
using Merge.Crm;

namespace Merge.Crm.AssociationTypes;

public partial class AssociationTypesClient
{
    private RawClient _client;

    internal AssociationTypesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `AssociationType` objects.
    /// </summary>
    private async Task<PaginatedAssociationTypeList> CustomObjectClassesAssociationTypesListInternalAsync(
        string customObjectClassId,
        CustomObjectClassesAssociationTypesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
                _query["expand"] = request.Expand.Select(_value => _value.ToString()).ToList();
                if (request.CreatedAfter != null)
                {
                    _query["created_after"] = request.CreatedAfter.Value.ToString(
                        Constants.DateTimeFormat
                    );
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
                    _query["include_deleted_data"] = JsonUtils.Serialize(
                        request.IncludeDeletedData.Value
                    );
                }
                if (request.IncludeRemoteData != null)
                {
                    _query["include_remote_data"] = JsonUtils.Serialize(
                        request.IncludeRemoteData.Value
                    );
                }
                if (request.IncludeShellData != null)
                {
                    _query["include_shell_data"] = JsonUtils.Serialize(
                        request.IncludeShellData.Value
                    );
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
                                "crm/v1/custom-object-classes/{0}/association-types",
                                ValueConvert.ToPathParameterString(customObjectClassId)
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
                        return JsonUtils.Deserialize<PaginatedAssociationTypeList>(responseBody)!;
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
            })
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Returns a list of `AssociationType` objects.
    /// </summary>
    /// <example><code>
    /// await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesListAsync(
    ///     "custom_object_class_id",
    ///     new CustomObjectClassesAssociationTypesListRequest()
    /// );
    /// </code></example>
    public async Task<Pager<AssociationType>> CustomObjectClassesAssociationTypesListAsync(
        string customObjectClassId,
        CustomObjectClassesAssociationTypesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                if (request is not null)
                {
                    request = request with { };
                }
                var pager = await CursorPager<
                    CustomObjectClassesAssociationTypesListRequest,
                    RequestOptions?,
                    PaginatedAssociationTypeList,
                    string?,
                    AssociationType
                >
                    .CreateInstanceAsync(
                        request,
                        options,
                        CustomObjectClassesAssociationTypesListInternalAsync,
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
            })
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Creates an `AssociationType` object with the given values.
    /// </summary>
    /// <example><code>
    /// await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesCreateAsync(
    ///     "custom_object_class_id",
    ///     new CrmAssociationTypeEndpointRequest
    ///     {
    ///         Model = new AssociationTypeRequestRequest
    ///         {
    ///             SourceObjectClass = new ObjectClassDescriptionRequest
    ///             {
    ///                 Id = "id",
    ///                 OriginType = OriginTypeEnum.CustomObject,
    ///             },
    ///             TargetObjectClasses = new List&lt;ObjectClassDescriptionRequest&gt;()
    ///             {
    ///                 new ObjectClassDescriptionRequest
    ///                 {
    ///                     Id = "id",
    ///                     OriginType = OriginTypeEnum.CustomObject,
    ///                 },
    ///             },
    ///             RemoteKeyName = "remote_key_name",
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async Task<CrmAssociationTypeResponse> CustomObjectClassesAssociationTypesCreateAsync(
        string customObjectClassId,
        CrmAssociationTypeEndpointRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
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
                            Method = HttpMethod.Post,
                            Path = string.Format(
                                "crm/v1/custom-object-classes/{0}/association-types",
                                ValueConvert.ToPathParameterString(customObjectClassId)
                            ),
                            Body = request,
                            Query = _query,
                            ContentType = "application/json",
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
                        return JsonUtils.Deserialize<CrmAssociationTypeResponse>(responseBody)!;
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
            })
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Returns an `AssociationType` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesRetrieveAsync(
    ///     "custom_object_class_id",
    ///     "id",
    ///     new CustomObjectClassesAssociationTypesRetrieveRequest()
    /// );
    /// </code></example>
    public async Task<AssociationType> CustomObjectClassesAssociationTypesRetrieveAsync(
        string customObjectClassId,
        string id,
        CustomObjectClassesAssociationTypesRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
                _query["expand"] = request.Expand.Select(_value => _value.ToString()).ToList();
                if (request.IncludeRemoteData != null)
                {
                    _query["include_remote_data"] = JsonUtils.Serialize(
                        request.IncludeRemoteData.Value
                    );
                }
                if (request.IncludeShellData != null)
                {
                    _query["include_shell_data"] = JsonUtils.Serialize(
                        request.IncludeShellData.Value
                    );
                }
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Get,
                            Path = string.Format(
                                "crm/v1/custom-object-classes/{0}/association-types/{1}",
                                ValueConvert.ToPathParameterString(customObjectClassId),
                                ValueConvert.ToPathParameterString(id)
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
                        return JsonUtils.Deserialize<AssociationType>(responseBody)!;
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
            })
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Returns metadata for `CRMAssociationType` POSTs.
    /// </summary>
    /// <example><code>
    /// await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesMetaPostRetrieveAsync(
    ///     "custom_object_class_id"
    /// );
    /// </code></example>
    public async Task<MetaResponse> CustomObjectClassesAssociationTypesMetaPostRetrieveAsync(
        string customObjectClassId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Get,
                            Path = string.Format(
                                "crm/v1/custom-object-classes/{0}/association-types/meta/post",
                                ValueConvert.ToPathParameterString(customObjectClassId)
                            ),
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
                        return JsonUtils.Deserialize<MetaResponse>(responseBody)!;
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
            })
            .ConfigureAwait(false);
    }
}
