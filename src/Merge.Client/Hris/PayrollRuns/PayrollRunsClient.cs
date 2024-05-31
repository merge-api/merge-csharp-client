using System.Text.Json;
using Merge.Client;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class PayrollRunsClient
{
    private RawClient _client;

    public PayrollRunsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `PayrollRun` objects.
    /// </summary>
    public async Task<PaginatedPayrollRunList> ListAsync(PayrollRunsListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.CreatedAfter != null)
        {
            _query["created_after"] = request.CreatedAfter;
        }
        if (request.CreatedBefore != null)
        {
            _query["created_before"] = request.CreatedBefore;
        }
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.EndedAfter != null)
        {
            _query["ended_after"] = request.EndedAfter;
        }
        if (request.EndedBefore != null)
        {
            _query["ended_before"] = request.EndedBefore;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData;
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.ModifiedAfter != null)
        {
            _query["modified_after"] = request.ModifiedAfter;
        }
        if (request.ModifiedBefore != null)
        {
            _query["modified_before"] = request.ModifiedBefore;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields;
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        if (request.RunType != null)
        {
            _query["run_type"] = request.RunType;
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins;
        }
        if (request.StartedAfter != null)
        {
            _query["started_after"] = request.StartedAfter;
        }
        if (request.StartedBefore != null)
        {
            _query["started_before"] = request.StartedBefore;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/hris/v1/payroll-runs",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedPayrollRunList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a `PayrollRun` object with the given `id`.
    /// </summary>
    public async Task<PayrollRun> RetrieveAsync(string id, PayrollRunsRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields;
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/hris/v1/payroll-runs/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PayrollRun>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
