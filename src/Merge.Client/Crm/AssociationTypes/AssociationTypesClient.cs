using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

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
    /// <example>
    /// <code>
    /// await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesListAsync(
    ///     "custom_object_class_id",
    ///     new CustomObjectClassesAssociationTypesListRequest()
    /// );
    /// </code>
    /// </example>
    public async Task<PaginatedAssociationTypeList> CustomObjectClassesAssociationTypesListAsync(
        string customObjectClassId,
        CustomObjectClassesAssociationTypesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
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
                Path = $"crm/v1/custom-object-classes/{customObjectClassId}/association-types",
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
                return JsonUtils.Deserialize<PaginatedAssociationTypeList>(responseBody)!;
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
    /// Creates an `AssociationType` object with the given values.
    /// </summary>
    /// <example>
    /// <code>
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
    ///             TargetObjectClasses = new List<ObjectClassDescriptionRequest>()
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
    /// </code>
    /// </example>
    public async Task<CrmAssociationTypeResponse> CustomObjectClassesAssociationTypesCreateAsync(
        string customObjectClassId,
        CrmAssociationTypeEndpointRequest request,
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
        var requestBody = new Dictionary<string, object>() { { "model", request.Model } };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = $"crm/v1/custom-object-classes/{customObjectClassId}/association-types",
                Body = requestBody,
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
                return JsonUtils.Deserialize<CrmAssociationTypeResponse>(responseBody)!;
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
    /// Returns an `AssociationType` object with the given `id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesRetrieveAsync(
    ///     "custom_object_class_id",
    ///     "id",
    ///     new CustomObjectClassesAssociationTypesRetrieveRequest()
    /// );
    /// </code>
    /// </example>
    public async Task<AssociationType> CustomObjectClassesAssociationTypesRetrieveAsync(
        string customObjectClassId,
        string id,
        CustomObjectClassesAssociationTypesRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand.ToString();
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"crm/v1/custom-object-classes/{customObjectClassId}/association-types/{id}",
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
                return JsonUtils.Deserialize<AssociationType>(responseBody)!;
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
    /// Returns metadata for `CRMAssociationType` POSTs.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesMetaPostRetrieveAsync(
    ///     "custom_object_class_id"
    /// );
    /// </code>
    /// </example>
    public async Task<MetaResponse> CustomObjectClassesAssociationTypesMetaPostRetrieveAsync(
        string customObjectClassId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path =
                    $"crm/v1/custom-object-classes/{customObjectClassId}/association-types/meta/post",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<MetaResponse>(responseBody)!;
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
