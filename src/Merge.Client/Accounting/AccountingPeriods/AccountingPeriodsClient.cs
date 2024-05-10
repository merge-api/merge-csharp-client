using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

namespace Merge.Client.Accounting;

public class AccountingPeriodsClient
{
    private RawClient _client;

    public AccountingPeriodsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `AccountingPeriod` objects.
    /// </summary>
    public async Task<PaginatedAccountingPeriodList> ListAsync(AccountingPeriodsListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData;
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/accounting/v1/accounting-periods",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedAccountingPeriodList>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns an `AccountingPeriod` object with the given `id`.
    /// </summary>
    public async Task<AccountingPeriod> RetrieveAsync(
        string id,
        AccountingPeriodsRetrieveRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/accounting/v1/accounting-periods/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AccountingPeriod>(responseBody);
        }
        throw new Exception();
    }
}
