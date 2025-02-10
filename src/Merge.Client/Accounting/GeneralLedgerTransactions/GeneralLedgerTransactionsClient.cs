using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

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
    /// <example>
    /// <code>
    /// await client.Accounting.GeneralLedgerTransactions.ListAsync(
    ///     new GeneralLedgerTransactionsListRequest()
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<PaginatedGeneralLedgerTransactionList> ListAsync(
        GeneralLedgerTransactionsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.CompanyId != null)
        {
            _query["company_id"] = request.CompanyId;
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
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "accounting/v1/general-ledger-transactions",
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
                return JsonUtils.Deserialize<PaginatedGeneralLedgerTransactionList>(responseBody)!;
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
    /// Returns a `GeneralLedgerTransaction` object with the given `id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Accounting.GeneralLedgerTransactions.RetrieveAsync(
    ///     "id",
    ///     new GeneralLedgerTransactionsRetrieveRequest()
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<GeneralLedgerTransaction> RetrieveAsync(
        string id,
        GeneralLedgerTransactionsRetrieveRequest request,
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
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = $"accounting/v1/general-ledger-transactions/{id}",
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
                return JsonUtils.Deserialize<GeneralLedgerTransaction>(responseBody)!;
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
