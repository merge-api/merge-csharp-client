using System.Text.Json;
using Merge.Client;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class EmployeePayrollRunsClient
{
    private RawClient _client;

    public EmployeePayrollRunsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `EmployeePayrollRun` objects.
    /// </summary>
    public async Task<PaginatedEmployeePayrollRunList> ListAsync(
        EmployeePayrollRunsListRequest request
    )
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
        if (request.EmployeeId != null)
        {
            _query["employee_id"] = request.EmployeeId;
        }
        if (request.EndedAfter != null)
        {
            _query["ended_after"] = request.EndedAfter;
        }
        if (request.EndedBefore != null)
        {
            _query["ended_before"] = request.EndedBefore;
        }
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand;
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
        if (request.PayrollRunId != null)
        {
            _query["payroll_run_id"] = request.PayrollRunId;
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
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
                Path = "/hris/v1/employee-payroll-runs",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedEmployeePayrollRunList>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns an `EmployeePayrollRun` object with the given `id`.
    /// </summary>
    public async Task<EmployeePayrollRun> RetrieveAsync(
        string id,
        EmployeePayrollRunsRetrieveRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand;
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/hris/v1/employee-payroll-runs/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EmployeePayrollRun>(responseBody);
        }
        throw new Exception();
    }
}
