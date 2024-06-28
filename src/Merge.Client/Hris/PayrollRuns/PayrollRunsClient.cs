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
        if (request.EndedAfter != null)
        {
            _query["ended_after"] = request.EndedAfter.Value.ToString("o0");
        }
        if (request.EndedBefore != null)
        {
            _query["ended_before"] = request.EndedBefore.Value.ToString("o0");
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
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = JsonSerializer.Serialize(request.RemoteFields.Value);
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        if (request.RunType != null)
        {
            _query["run_type"] = JsonSerializer.Serialize(request.RunType.Value);
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = JsonSerializer.Serialize(request.ShowEnumOrigins.Value);
        }
        if (request.StartedAfter != null)
        {
            _query["started_after"] = request.StartedAfter.Value.ToString("o0");
        }
        if (request.StartedBefore != null)
        {
            _query["started_before"] = request.StartedBefore.Value.ToString("o0");
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "hris/v1/payroll-runs",
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
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = JsonSerializer.Serialize(request.RemoteFields.Value);
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = JsonSerializer.Serialize(request.ShowEnumOrigins.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"hris/v1/payroll-runs/{id}",
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
