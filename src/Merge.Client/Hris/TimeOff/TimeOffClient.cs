using System.Text.Json;
using Merge.Client;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class TimeOffClient
{
    private RawClient _client;

    public TimeOffClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `TimeOff` objects.
    /// </summary>
    public async Task<PaginatedTimeOffList> ListAsync(TimeOffListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.ApproverId != null)
        {
            _query["approver_id"] = request.ApproverId;
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
        if (request.EmployeeId != null)
        {
            _query["employee_id"] = request.EmployeeId;
        }
        if (request.EndedAfter != null)
        {
            _query["ended_after"] = request.EndedAfter.Value.ToString("o0");
        }
        if (request.EndedBefore != null)
        {
            _query["ended_before"] = request.EndedBefore.Value.ToString("o0");
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
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields.ToString();
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        if (request.RequestType != null)
        {
            _query["request_type"] = request.RequestType.ToString();
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins.ToString();
        }
        if (request.StartedAfter != null)
        {
            _query["started_after"] = request.StartedAfter.Value.ToString("o0");
        }
        if (request.StartedBefore != null)
        {
            _query["started_before"] = request.StartedBefore.Value.ToString("o0");
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/hris/v1/time-off",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedTimeOffList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a `TimeOff` object with the given values.
    /// </summary>
    public async Task<TimeOffResponse> CreateAsync(TimeOffEndpointRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = request.IsDebugMode.ToString();
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = request.RunAsync.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/hris/v1/time-off",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<TimeOffResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a `TimeOff` object with the given `id`.
    /// </summary>
    public async Task<TimeOff> RetrieveAsync(string id, TimeOffRetrieveRequest request)
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
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields.ToString();
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/hris/v1/time-off/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<TimeOff>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns metadata for `TimeOff` POSTs.
    /// </summary>
    public async Task<MetaResponse> MetaPostRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/hris/v1/time-off/meta/post"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MetaResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
