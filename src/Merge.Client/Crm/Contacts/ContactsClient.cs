using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public partial class ContactsClient
{
    private RawClient _client;

    internal ContactsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Contact` objects.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.Contacts.ListAsync(new ContactsListRequest());
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<PaginatedContactList> ListAsync(
        ContactsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.AccountId != null)
        {
            _query["account_id"] = request.AccountId;
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
        if (request.EmailAddresses != null)
        {
            _query["email_addresses"] = request.EmailAddresses;
        }
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand.Value.Stringify();
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
        if (request.PhoneNumbers != null)
        {
            _query["phone_numbers"] = request.PhoneNumbers;
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
                    Path = "crm/v1/contacts",
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
                return JsonUtils.Deserialize<PaginatedContactList>(responseBody)!;
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
    /// Creates a `Contact` object with the given values.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.Contacts.CreateAsync(
    ///     new CrmContactEndpointRequest { Model = new Merge.Client.Crm.ContactRequest() }
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<CrmContactResponse> CreateAsync(
        CrmContactEndpointRequest request,
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
                    Path = "crm/v1/contacts",
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
                return JsonUtils.Deserialize<CrmContactResponse>(responseBody)!;
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
    /// Returns a `Contact` object with the given `id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.Contacts.RetrieveAsync("id", new ContactsRetrieveRequest());
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<Contact> RetrieveAsync(
        string id,
        ContactsRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand.Value.Stringify();
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
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = $"crm/v1/contacts/{id}",
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
                return JsonUtils.Deserialize<Contact>(responseBody)!;
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
    /// Updates a `Contact` object with the given `id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.Contacts.PartialUpdateAsync(
    ///     "id",
    ///     new PatchedCrmContactEndpointRequest { Model = new PatchedContactRequest() }
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<CrmContactResponse> PartialUpdateAsync(
        string id,
        PatchedCrmContactEndpointRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = $"crm/v1/contacts/{id}",
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
                return JsonUtils.Deserialize<CrmContactResponse>(responseBody)!;
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
    /// Ignores a specific row based on the `model_id` in the url. These records will have their properties set to null, and will not be updated in future syncs. The "reason" and "message" fields in the request body will be stored for audit purposes.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.Contacts.IgnoreCreateAsync(
    ///     "model_id",
    ///     new IgnoreCommonModelRequest { Reason = Merge.Client.Crm.ReasonEnum.GeneralCustomerRequest }
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task IgnoreCreateAsync(
        string modelId,
        IgnoreCommonModelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = $"crm/v1/contacts/ignore/{modelId}",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Returns metadata for `CRMContact` PATCHs.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.Contacts.MetaPatchRetrieveAsync("id");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<MetaResponse> MetaPatchRetrieveAsync(
        string id,
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
                    Path = $"crm/v1/contacts/meta/patch/{id}",
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
    /// Returns metadata for `CRMContact` POSTs.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.Contacts.MetaPostRetrieveAsync();
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<MetaResponse> MetaPostRetrieveAsync(
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
                    Path = "crm/v1/contacts/meta/post",
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
    /// await client.Crm.Contacts.RemoteFieldClassesListAsync(new ContactsRemoteFieldClassesListRequest());
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<PaginatedRemoteFieldClassList> RemoteFieldClassesListAsync(
        ContactsRemoteFieldClassesListRequest request,
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
                    Path = "crm/v1/contacts/remote-field-classes",
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
