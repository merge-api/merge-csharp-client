using System.Text.Json;
using Merge.Client;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class EmployeesClient
{
    private RawClient _client;

    public EmployeesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Employee` objects.
    /// </summary>
    public async Task<PaginatedEmployeeList> ListAsync(EmployeesListRequest request)
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
        if (request.DisplayFullName != null)
        {
            _query["display_full_name"] = request.DisplayFullName;
        }
        if (request.EmploymentStatus != null)
        {
            _query["employment_status"] = request.EmploymentStatus.ToString();
        }
        if (request.EmploymentType != null)
        {
            _query["employment_type"] = request.EmploymentType;
        }
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand.ToString();
        }
        if (request.FirstName != null)
        {
            _query["first_name"] = request.FirstName;
        }
        if (request.Groups != null)
        {
            _query["groups"] = request.Groups;
        }
        if (request.HomeLocationId != null)
        {
            _query["home_location_id"] = request.HomeLocationId;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData.ToString();
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        if (request.IncludeSensitiveFields != null)
        {
            _query["include_sensitive_fields"] = request.IncludeSensitiveFields.ToString();
        }
        if (request.JobTitle != null)
        {
            _query["job_title"] = request.JobTitle;
        }
        if (request.LastName != null)
        {
            _query["last_name"] = request.LastName;
        }
        if (request.ManagerId != null)
        {
            _query["manager_id"] = request.ManagerId;
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
        if (request.PayGroupId != null)
        {
            _query["pay_group_id"] = request.PayGroupId;
        }
        if (request.PersonalEmail != null)
        {
            _query["personal_email"] = request.PersonalEmail;
        }
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields.ToString();
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
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
        if (request.TeamId != null)
        {
            _query["team_id"] = request.TeamId;
        }
        if (request.TerminatedAfter != null)
        {
            _query["terminated_after"] = request.TerminatedAfter.Value.ToString("o0");
        }
        if (request.TerminatedBefore != null)
        {
            _query["terminated_before"] = request.TerminatedBefore.Value.ToString("o0");
        }
        if (request.WorkEmail != null)
        {
            _query["work_email"] = request.WorkEmail;
        }
        if (request.WorkLocationId != null)
        {
            _query["work_location_id"] = request.WorkLocationId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/hris/v1/employees",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedEmployeeList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates an `Employee` object with the given values.
    /// </summary>
    public async Task<EmployeeResponse> CreateAsync(EmployeeEndpointRequest request)
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
                Path = "/hris/v1/employees",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<EmployeeResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns an `Employee` object with the given `id`.
    /// </summary>
    public async Task<Employee> RetrieveAsync(string id, EmployeesRetrieveRequest request)
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
        if (request.IncludeSensitiveFields != null)
        {
            _query["include_sensitive_fields"] = request.IncludeSensitiveFields.ToString();
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
                Path = $"/hris/v1/employees/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Employee>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Ignores a specific row based on the `model_id` in the url. These records will have their properties set to null, and will not be updated in future syncs. The "reason" and "message" fields in the request body will be stored for audit purposes.
    /// </summary>
    public async void IgnoreCreateAsync(string modelId, IgnoreCommonModelRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/hris/v1/employees/ignore/{modelId}",
                Body = request
            }
        );
    }

    /// <summary>
    /// Returns metadata for `Employee` POSTs.
    /// </summary>
    public async Task<MetaResponse> MetaPostRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/hris/v1/employees/meta/post"
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
