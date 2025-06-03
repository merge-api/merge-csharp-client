using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge;
using Merge.Accounting;
using Merge.Core;

namespace Merge.Accounting.PaymentTerms;

public partial class PaymentTermsClient
{
    private RawClient _client;

    internal PaymentTermsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `PaymentTerm` objects.
    /// </summary>
    private async Task<PaginatedPaymentTermList> ListInternalAsync(
        PaymentTermsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
                _query["expand"] = request.Expand.Select(_value => _value.ToString()).ToList();
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
                            Path = "accounting/v1/payment-terms",
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
                        return JsonUtils.Deserialize<PaginatedPaymentTermList>(responseBody)!;
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
    /// Returns a list of `PaymentTerm` objects.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.PaymentTerms.ListAsync(new PaymentTermsListRequest());
    /// </code></example>
    public async Task<Pager<PaymentTerm>> ListAsync(
        PaymentTermsListRequest request,
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
                    PaymentTermsListRequest,
                    RequestOptions?,
                    PaginatedPaymentTermList,
                    string?,
                    PaymentTerm
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
    /// Returns a `PaymentTerm` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.PaymentTerms.RetrieveAsync("id", new PaymentTermsRetrieveRequest());
    /// </code></example>
    public async Task<PaymentTerm> RetrieveAsync(
        string id,
        PaymentTermsRetrieveRequest request,
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
                                "accounting/v1/payment-terms/{0}",
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
                        return JsonUtils.Deserialize<PaymentTerm>(responseBody)!;
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
