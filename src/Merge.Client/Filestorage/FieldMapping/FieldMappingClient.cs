using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Filestorage;

public partial class FieldMappingClient
{
    private RawClient _client;

    internal FieldMappingClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get all Field Mappings for this Linked Account. Field Mappings are mappings between third-party Remote Fields and user defined Merge fields. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/overview/).
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Filestorage.FieldMapping.FieldMappingsRetrieveAsync(
    ///     new FieldMappingsRetrieveRequest()
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<FieldMappingApiInstanceResponse> FieldMappingsRetrieveAsync(
        FieldMappingsRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.ExcludeRemoteFieldMetadata != null)
        {
            _query["exclude_remote_field_metadata"] = JsonUtils.Serialize(
                request.ExcludeRemoteFieldMetadata.Value
            );
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "filestorage/v1/field-mappings",
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
                return JsonUtils.Deserialize<FieldMappingApiInstanceResponse>(responseBody)!;
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
    /// Create new Field Mappings that will be available after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Filestorage.FieldMapping.FieldMappingsCreateAsync(
    ///     new CreateFieldMappingRequest
    ///     {
    ///         TargetFieldName = "example_target_field_name",
    ///         TargetFieldDescription = "this is a example description of the target field",
    ///         RemoteFieldTraversalPath = new List&lt;object&gt;() { "example_remote_field" },
    ///         RemoteMethod = "GET",
    ///         RemoteUrlPath = "/example-url-path",
    ///         CommonModelName = "ExampleCommonModel",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<FieldMappingInstanceResponse> FieldMappingsCreateAsync(
        CreateFieldMappingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.ExcludeRemoteFieldMetadata != null)
        {
            _query["exclude_remote_field_metadata"] = JsonUtils.Serialize(
                request.ExcludeRemoteFieldMetadata.Value
            );
        }
        var requestBody = new Dictionary<string, object>()
        {
            { "target_field_name", request.TargetFieldName },
            { "target_field_description", request.TargetFieldDescription },
            { "remote_field_traversal_path", request.RemoteFieldTraversalPath },
            { "remote_method", request.RemoteMethod },
            { "remote_url_path", request.RemoteUrlPath },
            { "common_model_name", request.CommonModelName },
        };
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "filestorage/v1/field-mappings",
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
                return JsonUtils.Deserialize<FieldMappingInstanceResponse>(responseBody)!;
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
    /// Deletes Field Mappings for a Linked Account. All data related to this Field Mapping will be deleted and these changes will be reflected after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Filestorage.FieldMapping.FieldMappingsDestroyAsync("field_mapping_id");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<FieldMappingInstanceResponse> FieldMappingsDestroyAsync(
        string fieldMappingId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Delete,
                    Path = $"filestorage/v1/field-mappings/{fieldMappingId}",
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
                return JsonUtils.Deserialize<FieldMappingInstanceResponse>(responseBody)!;
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
    /// Create or update existing Field Mappings for a Linked Account. Changes will be reflected after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Filestorage.FieldMapping.FieldMappingsPartialUpdateAsync(
    ///     "field_mapping_id",
    ///     new PatchedEditFieldMappingRequest()
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<FieldMappingInstanceResponse> FieldMappingsPartialUpdateAsync(
        string fieldMappingId,
        PatchedEditFieldMappingRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethodExtensions.Patch,
                    Path = $"filestorage/v1/field-mappings/{fieldMappingId}",
                    Body = request,
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
                return JsonUtils.Deserialize<FieldMappingInstanceResponse>(responseBody)!;
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
    /// Get all remote fields for a Linked Account. Remote fields are third-party fields that are accessible after initial sync if remote_data is enabled. You can use remote fields to override existing Merge fields or map a new Merge field. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/overview/).
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Filestorage.FieldMapping.RemoteFieldsRetrieveAsync(new RemoteFieldsRetrieveRequest());
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<RemoteFieldApiResponse> RemoteFieldsRetrieveAsync(
        RemoteFieldsRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.CommonModels != null)
        {
            _query["common_models"] = request.CommonModels;
        }
        if (request.IncludeExampleValues != null)
        {
            _query["include_example_values"] = request.IncludeExampleValues;
        }
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "filestorage/v1/remote-fields",
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
                return JsonUtils.Deserialize<RemoteFieldApiResponse>(responseBody)!;
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
    /// Get all organization-wide Target Fields, this will not include any Linked Account specific Target Fields. Organization-wide Target Fields are additional fields appended to the Merge Common Model for all Linked Accounts in a category. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/target-fields/).
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Filestorage.FieldMapping.TargetFieldsRetrieveAsync();
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<ExternalTargetFieldApiResponse> TargetFieldsRetrieveAsync(
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
                    Path = "filestorage/v1/target-fields",
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
                return JsonUtils.Deserialize<ExternalTargetFieldApiResponse>(responseBody)!;
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
