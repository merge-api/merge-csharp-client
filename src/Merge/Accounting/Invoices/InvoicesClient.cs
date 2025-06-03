using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge;
using Merge.Accounting;
using Merge.Core;

namespace Merge.Accounting.Invoices;

public partial class InvoicesClient
{
    private RawClient _client;

    internal InvoicesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Invoice` objects.
    /// </summary>
    private async Task<PaginatedInvoiceList> ListInternalAsync(
        InvoicesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
                _query["expand"] = request.Expand.Select(_value => _value.Stringify()).ToList();
                if (request.CompanyId != null)
                {
                    _query["company_id"] = request.CompanyId;
                }
                if (request.ContactId != null)
                {
                    _query["contact_id"] = request.ContactId;
                }
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
                if (request.IncludeRemoteFields != null)
                {
                    _query["include_remote_fields"] = JsonUtils.Serialize(
                        request.IncludeRemoteFields.Value
                    );
                }
                if (request.IncludeShellData != null)
                {
                    _query["include_shell_data"] = JsonUtils.Serialize(
                        request.IncludeShellData.Value
                    );
                }
                if (request.IssueDateAfter != null)
                {
                    _query["issue_date_after"] = request.IssueDateAfter.Value.ToString(
                        Constants.DateTimeFormat
                    );
                }
                if (request.IssueDateBefore != null)
                {
                    _query["issue_date_before"] = request.IssueDateBefore.Value.ToString(
                        Constants.DateTimeFormat
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
                if (request.Number != null)
                {
                    _query["number"] = request.Number;
                }
                if (request.PageSize != null)
                {
                    _query["page_size"] = request.PageSize.Value.ToString();
                }
                if (request.RemoteFields != null)
                {
                    _query["remote_fields"] = request.RemoteFields.ToString();
                }
                if (request.RemoteId != null)
                {
                    _query["remote_id"] = request.RemoteId;
                }
                if (request.ShowEnumOrigins != null)
                {
                    _query["show_enum_origins"] = request.ShowEnumOrigins.ToString();
                }
                if (request.Status != null)
                {
                    _query["status"] = request.Status.Value.Stringify();
                }
                if (request.Type != null)
                {
                    _query["type"] = request.Type.Value.Stringify();
                }
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Get,
                            Path = "accounting/v1/invoices",
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
                        return JsonUtils.Deserialize<PaginatedInvoiceList>(responseBody)!;
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
    /// Returns a list of `RemoteFieldClass` objects.
    /// </summary>
    private async Task<PaginatedRemoteFieldClassList> LineItemsRemoteFieldClassesListInternalAsync(
        InvoicesLineItemsRemoteFieldClassesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
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
                if (request.IsCommonModelField != null)
                {
                    _query["is_common_model_field"] = JsonUtils.Serialize(
                        request.IsCommonModelField.Value
                    );
                }
                if (request.PageSize != null)
                {
                    _query["page_size"] = request.PageSize.Value.ToString();
                }
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Get,
                            Path = "accounting/v1/invoices/line-items/remote-field-classes",
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
                        return JsonUtils.Deserialize<PaginatedRemoteFieldClassList>(responseBody)!;
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
    /// Returns a list of `RemoteFieldClass` objects.
    /// </summary>
    private async Task<PaginatedRemoteFieldClassList> RemoteFieldClassesListInternalAsync(
        InvoicesRemoteFieldClassesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
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
                if (request.IsCommonModelField != null)
                {
                    _query["is_common_model_field"] = JsonUtils.Serialize(
                        request.IsCommonModelField.Value
                    );
                }
                if (request.PageSize != null)
                {
                    _query["page_size"] = request.PageSize.Value.ToString();
                }
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Get,
                            Path = "accounting/v1/invoices/remote-field-classes",
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
                        return JsonUtils.Deserialize<PaginatedRemoteFieldClassList>(responseBody)!;
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
    /// Returns a list of `Invoice` objects.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.Invoices.ListAsync(new InvoicesListRequest());
    /// </code></example>
    public async Task<Pager<Invoice>> ListAsync(
        InvoicesListRequest request,
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
                    InvoicesListRequest,
                    RequestOptions?,
                    PaginatedInvoiceList,
                    string?,
                    Invoice
                >
                    .CreateInstanceAsync(
                        request,
                        options,
                        ListInternalAsync,
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
    /// Creates an `Invoice` object with the given values.
    ///             Including a `PurchaseOrder` id in the `purchase_orders` property will generate an Accounts Payable Invoice from the specified Purchase Order(s).
    /// </summary>
    /// <example><code>
    /// await client.Accounting.Invoices.CreateAsync(
    ///     new InvoiceEndpointRequest { Model = new InvoiceRequest() }
    /// );
    /// </code></example>
    public async Task<InvoiceResponse> CreateAsync(
        InvoiceEndpointRequest request,
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
                            Path = "accounting/v1/invoices",
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
                        return JsonUtils.Deserialize<InvoiceResponse>(responseBody)!;
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
    /// Returns an `Invoice` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.Invoices.RetrieveAsync("id", new InvoicesRetrieveRequest());
    /// </code></example>
    public async Task<Invoice> RetrieveAsync(
        string id,
        InvoicesRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
                _query["expand"] = request.Expand.Select(_value => _value.Stringify()).ToList();
                if (request.IncludeRemoteData != null)
                {
                    _query["include_remote_data"] = JsonUtils.Serialize(
                        request.IncludeRemoteData.Value
                    );
                }
                if (request.IncludeRemoteFields != null)
                {
                    _query["include_remote_fields"] = JsonUtils.Serialize(
                        request.IncludeRemoteFields.Value
                    );
                }
                if (request.IncludeShellData != null)
                {
                    _query["include_shell_data"] = JsonUtils.Serialize(
                        request.IncludeShellData.Value
                    );
                }
                if (request.RemoteFields != null)
                {
                    _query["remote_fields"] = request.RemoteFields.ToString();
                }
                if (request.ShowEnumOrigins != null)
                {
                    _query["show_enum_origins"] = request.ShowEnumOrigins.ToString();
                }
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Get,
                            Path = string.Format(
                                "accounting/v1/invoices/{0}",
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
                        return JsonUtils.Deserialize<Invoice>(responseBody)!;
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
    /// Updates an `Invoice` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.Invoices.PartialUpdateAsync(
    ///     "id",
    ///     new PatchedInvoiceEndpointRequest { Model = new InvoiceRequest() }
    /// );
    /// </code></example>
    public async Task<InvoiceResponse> PartialUpdateAsync(
        string id,
        PatchedInvoiceEndpointRequest request,
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
                            Method = HttpMethodExtensions.Patch,
                            Path = string.Format(
                                "accounting/v1/invoices/{0}",
                                ValueConvert.ToPathParameterString(id)
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
                        return JsonUtils.Deserialize<InvoiceResponse>(responseBody)!;
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
    /// Returns a list of `RemoteFieldClass` objects.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.Invoices.LineItemsRemoteFieldClassesListAsync(
    ///     new InvoicesLineItemsRemoteFieldClassesListRequest()
    /// );
    /// </code></example>
    public async Task<Pager<RemoteFieldClass>> LineItemsRemoteFieldClassesListAsync(
        InvoicesLineItemsRemoteFieldClassesListRequest request,
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
                    InvoicesLineItemsRemoteFieldClassesListRequest,
                    RequestOptions?,
                    PaginatedRemoteFieldClassList,
                    string?,
                    RemoteFieldClass
                >
                    .CreateInstanceAsync(
                        request,
                        options,
                        LineItemsRemoteFieldClassesListInternalAsync,
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
    /// Returns metadata for `Invoice` PATCHs.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.Invoices.MetaPatchRetrieveAsync("id");
    /// </code></example>
    public async Task<MetaResponse> MetaPatchRetrieveAsync(
        string id,
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
                                "accounting/v1/invoices/meta/patch/{0}",
                                ValueConvert.ToPathParameterString(id)
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

    /// <summary>
    /// Returns metadata for `Invoice` POSTs.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.Invoices.MetaPostRetrieveAsync();
    /// </code></example>
    public async Task<MetaResponse> MetaPostRetrieveAsync(
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
                            Path = "accounting/v1/invoices/meta/post",
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

    /// <summary>
    /// Returns a list of `RemoteFieldClass` objects.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.Invoices.RemoteFieldClassesListAsync(
    ///     new InvoicesRemoteFieldClassesListRequest()
    /// );
    /// </code></example>
    public async Task<Pager<RemoteFieldClass>> RemoteFieldClassesListAsync(
        InvoicesRemoteFieldClassesListRequest request,
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
                    InvoicesRemoteFieldClassesListRequest,
                    RequestOptions?,
                    PaginatedRemoteFieldClassList,
                    string?,
                    RemoteFieldClass
                >
                    .CreateInstanceAsync(
                        request,
                        options,
                        RemoteFieldClassesListInternalAsync,
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
}
