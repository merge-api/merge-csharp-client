using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public partial class CustomObjectsClient
{
    private RawClient _client;

    internal CustomObjectsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `CustomObject` objects.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.CustomObjects.CustomObjectClassesCustomObjectsListAsync(
    ///     "custom_object_class_id",
    ///     new CustomObjectClassesCustomObjectsListRequest()
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<PaginatedCustomObjectList> CustomObjectClassesCustomObjectsListAsync(
        string customObjectClassId,
        CustomObjectClassesCustomObjectsListRequest request,
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
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = JsonUtils.Serialize(request.IncludeDeletedData.Value);
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = JsonUtils.Serialize(request.IncludeRemoteData.Value);
        }
        if (request.IncludeRemoteFields != null)
        {
            _query["include_remote_fields"] = JsonUtils.Serialize(
                request.IncludeRemoteFields.Value
            );
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
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = $"crm/v1/custom-object-classes/{customObjectClassId}/custom-objects",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PaginatedCustomObjectList>(responseBody)!;
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
    /// Creates a `CustomObject` object with the given values.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.CustomObjects.CustomObjectClassesCustomObjectsCreateAsync(
    ///     "custom_object_class_id",
    ///     new CrmCustomObjectEndpointRequest
    ///     {
    ///         Model = new CustomObjectRequest
    ///         {
    ///             Fields = new Dictionary&lt;string, object&gt;() { { "test_field", "hello" } },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<CrmCustomObjectResponse> CustomObjectClassesCustomObjectsCreateAsync(
        string customObjectClassId,
        CrmCustomObjectEndpointRequest request,
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
        var requestBody = new Dictionary<string, object>() { { "model", request.Model } };
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = $"crm/v1/custom-object-classes/{customObjectClassId}/custom-objects",
                    Body = requestBody,
                    Query = _query,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CrmCustomObjectResponse>(responseBody)!;
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
    /// Returns a `CustomObject` object with the given `id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.CustomObjects.CustomObjectClassesCustomObjectsRetrieveAsync(
    ///     "custom_object_class_id",
    ///     "id",
    ///     new CustomObjectClassesCustomObjectsRetrieveRequest()
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<CustomObject> CustomObjectClassesCustomObjectsRetrieveAsync(
        string customObjectClassId,
        string id,
        CustomObjectClassesCustomObjectsRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = JsonUtils.Serialize(request.IncludeRemoteData.Value);
        }
        if (request.IncludeRemoteFields != null)
        {
            _query["include_remote_fields"] = JsonUtils.Serialize(
                request.IncludeRemoteFields.Value
            );
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path =
                        $"crm/v1/custom-object-classes/{customObjectClassId}/custom-objects/{id}",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CustomObject>(responseBody)!;
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
    /// Returns metadata for `CRMCustomObject` POSTs.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.CustomObjects.CustomObjectClassesCustomObjectsMetaPostRetrieveAsync(
    ///     "custom_object_class_id"
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<MetaResponse> CustomObjectClassesCustomObjectsMetaPostRetrieveAsync(
        string customObjectClassId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path =
                        $"crm/v1/custom-object-classes/{customObjectClassId}/custom-objects/meta/post",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
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

    /// <summary>
    /// Returns a list of `RemoteFieldClass` objects.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.CustomObjects.CustomObjectClassesCustomObjectsRemoteFieldClassesListAsync(
    ///     new CustomObjectClassesCustomObjectsRemoteFieldClassesListRequest()
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<PaginatedRemoteFieldClassList> CustomObjectClassesCustomObjectsRemoteFieldClassesListAsync(
        CustomObjectClassesCustomObjectsRemoteFieldClassesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
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
        if (request.IncludeRemoteFields != null)
        {
            _query["include_remote_fields"] = JsonUtils.Serialize(
                request.IncludeRemoteFields.Value
            );
        }
        if (request.IncludeShellData != null)
        {
            _query["include_shell_data"] = JsonUtils.Serialize(request.IncludeShellData.Value);
        }
        if (request.IsCommonModelField != null)
        {
            _query["is_common_model_field"] = JsonUtils.Serialize(request.IsCommonModelField.Value);
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.Value.ToString();
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "crm/v1/custom-object-classes/custom-objects/remote-field-classes",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PaginatedRemoteFieldClassList>(responseBody)!;
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
