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
            _query["created_after"] = request.CreatedAfter.ToString("o0");
        }
        if (request.CreatedBefore != null)
        {
            _query["created_before"] = request.CreatedBefore.ToString("o0");
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
            _query["ended_after"] = request.EndedAfter.ToString("o0");
        }
        if (request.EndedBefore != null)
        {
            _query["ended_before"] = request.EndedBefore.ToString("o0");
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
            _query["modified_after"] = request.ModifiedAfter.ToString("o0");
        }
        if (request.ModifiedBefore != null)
        {
            _query["modified_before"] = request.ModifiedBefore.ToString("o0");
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.ToString();
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
            _query["started_after"] = request.StartedAfter.ToString("o0");
        }
        if (request.StartedBefore != null)
        {
            _query["started_before"] = request.StartedBefore.ToString("o0");
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
        throw new Exception(responseBody);
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
                Path = $"/hris/v1/employee-payroll-runs/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EmployeePayrollRun>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
