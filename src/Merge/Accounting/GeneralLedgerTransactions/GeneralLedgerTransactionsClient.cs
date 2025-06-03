using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge;
using Merge.Accounting;
using Merge.Core;

namespace Merge.Accounting.GeneralLedgerTransactions;

public partial class GeneralLedgerTransactionsClient
{
    private RawClient _client;

    internal GeneralLedgerTransactionsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `GeneralLedgerTransaction` objects.
    /// </summary>
    private async Task<PaginatedGeneralLedgerTransactionList> ListInternalAsync(
        GeneralLedgerTransactionsListRequest request,
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
                if (request.PostedDateAfter != null)
                {
                    _query["posted_date_after"] = request.PostedDateAfter.Value.ToString(
                        Constants.DateTimeFormat
                    );
                }
                if (request.PostedDateBefore != null)
                {
                    _query["posted_date_before"] = request.PostedDateBefore.Value.ToString(
                        Constants.DateTimeFormat
                    );
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
                            Path = "accounting/v1/general-ledger-transactions",
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
                        return JsonUtils.Deserialize<PaginatedGeneralLedgerTransactionList>(
                            responseBody
                        )!;
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
    /// Returns a list of `GeneralLedgerTransaction` objects.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.GeneralLedgerTransactions.ListAsync(
    ///     new GeneralLedgerTransactionsListRequest()
    /// );
    /// </code></example>
    public async Task<Pager<GeneralLedgerTransaction>> ListAsync(
        GeneralLedgerTransactionsListRequest request,
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
                    GeneralLedgerTransactionsListRequest,
                    RequestOptions?,
                    PaginatedGeneralLedgerTransactionList,
                    string?,
                    GeneralLedgerTransaction
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
    /// Returns a `GeneralLedgerTransaction` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.GeneralLedgerTransactions.RetrieveAsync(
    ///     "id",
    ///     new GeneralLedgerTransactionsRetrieveRequest()
    /// );
    /// </code></example>
    public async Task<GeneralLedgerTransaction> RetrieveAsync(
        string id,
        GeneralLedgerTransactionsRetrieveRequest request,
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
                                "accounting/v1/general-ledger-transactions/{0}",
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
                        return JsonUtils.Deserialize<GeneralLedgerTransaction>(responseBody)!;
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
