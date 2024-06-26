using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class CashFlowStatementsClient
{
    private RawClient _client;

    public CashFlowStatementsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `CashFlowStatement` objects.
    /// </summary>
    public async Task<PaginatedCashFlowStatementList> ListAsync(
        CashFlowStatementsListRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.CompanyId != null)
        {
            _query["company_id"] = request.CompanyId;
        }
        if (request.CreatedAfter != null)
        {
            _query["created_after"] = request.CreatedAfter.Value.ToString("o0");
        }
        if (request.CreatedBefore != null)
        {
            _query["created_before"] = request.CreatedBefore.Value.ToString("o0");
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
            _query["modified_after"] = request.ModifiedAfter.Value.ToString("o0");
        }
        if (request.ModifiedBefore != null)
        {
            _query["modified_before"] = request.ModifiedBefore.Value.ToString("o0");
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
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/accounting/v1/cash-flow-statements",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedCashFlowStatementList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a `CashFlowStatement` object with the given `id`.
    /// </summary>
    public async Task<CashFlowStatement> RetrieveAsync(
        string id,
        CashFlowStatementsRetrieveRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand.ToString();
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/accounting/v1/cash-flow-statements/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CashFlowStatement>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
