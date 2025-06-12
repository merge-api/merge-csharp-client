using System.Net.Http;
using System.Text.Json;
using System.Threading;
using global::System.Threading.Tasks;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public partial class EmployeesClient
{
    private RawClient _client;

    internal EmployeesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Employee` objects.
    /// </summary>
    private async Task<PaginatedEmployeeList> ListInternalAsync(
        EmployeesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["expand"] = request.Expand.Select(_value => _value.Stringify()).ToList();
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
        if (request.DisplayFullName != null)
        {
            _query["display_full_name"] = request.DisplayFullName;
        }
        if (request.EmploymentStatus != null)
        {
            _query["employment_status"] = request.EmploymentStatus.Value.Stringify();
        }
        if (request.EmploymentType != null)
        {
            _query["employment_type"] = request.EmploymentType;
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
            _query["include_deleted_data"] = JsonUtils.Serialize(request.IncludeDeletedData.Value);
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = JsonUtils.Serialize(request.IncludeRemoteData.Value);
        }
        if (request.IncludeSensitiveFields != null)
        {
            _query["include_sensitive_fields"] = JsonUtils.Serialize(
                request.IncludeSensitiveFields.Value
            );
        }
        if (request.IncludeShellData != null)
        {
            _query["include_shell_data"] = JsonUtils.Serialize(request.IncludeShellData.Value);
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
            _query["remote_fields"] = request.RemoteFields.Value.Stringify();
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins.Value.Stringify();
        }
        if (request.StartedAfter != null)
        {
            _query["started_after"] = request.StartedAfter.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.StartedBefore != null)
        {
            _query["started_before"] = request.StartedBefore.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.TeamId != null)
        {
            _query["team_id"] = request.TeamId;
        }
        if (request.TerminatedAfter != null)
        {
            _query["terminated_after"] = request.TerminatedAfter.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.TerminatedBefore != null)
        {
            _query["terminated_before"] = request.TerminatedBefore.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.WorkEmail != null)
        {
            _query["work_email"] = request.WorkEmail;
        }
        if (request.WorkLocationId != null)
        {
            _query["work_location_id"] = request.WorkLocationId;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "hris/v1/employees",
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
                return JsonUtils.Deserialize<PaginatedEmployeeList>(responseBody)!;
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
    }

    /// <summary>
    /// Returns a list of `Employee` objects.
    /// </summary>
    /// <example><code>
    /// await client.Hris.Employees.ListAsync(new EmployeesListRequest());
    /// </code></example>
    public async Task<Pager<Employee>> ListAsync(
        EmployeesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            EmployeesListRequest,
            RequestOptions?,
            PaginatedEmployeeList,
            string?,
            Employee
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
    }

    /// <summary>
    /// Creates an `Employee` object with the given values.
    /// </summary>
    /// <example><code>
    /// await client.Hris.Employees.CreateAsync(
    ///     new EmployeeEndpointRequest { Model = new EmployeeRequest() }
    /// );
    /// </code></example>
    public async Task<EmployeeResponse> CreateAsync(
        EmployeeEndpointRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = JsonUtils.Serialize(request.IsDebugMode.Value);
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = JsonUtils.Serialize(request.RunAsync.Value);
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "hris/v1/employees",
                    Body = request,
                    Query = _query,
                    ContentType = "application/json",
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
                return JsonUtils.Deserialize<EmployeeResponse>(responseBody)!;
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
    }

    /// <summary>
    /// Returns an `Employee` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Hris.Employees.RetrieveAsync("id", new EmployeesRetrieveRequest());
    /// </code></example>
    public async Task<Employee> RetrieveAsync(
        string id,
        EmployeesRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["expand"] = request.Expand.Select(_value => _value.Stringify()).ToList();
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = JsonUtils.Serialize(request.IncludeRemoteData.Value);
        }
        if (request.IncludeSensitiveFields != null)
        {
            _query["include_sensitive_fields"] = JsonUtils.Serialize(
                request.IncludeSensitiveFields.Value
            );
        }
        if (request.IncludeShellData != null)
        {
            _query["include_shell_data"] = JsonUtils.Serialize(request.IncludeShellData.Value);
        }
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields.Value.Stringify();
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "hris/v1/employees/{0}",
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
                return JsonUtils.Deserialize<Employee>(responseBody)!;
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
    }

    /// <summary>
    /// Ignores a specific row based on the `model_id` in the url. These records will have their properties set to null, and will not be updated in future syncs. The "reason" and "message" fields in the request body will be stored for audit purposes.
    /// </summary>
    /// <example><code>
    /// await client.Hris.Employees.IgnoreCreateAsync(
    ///     "model_id",
    ///     new Merge.Client.Hris.IgnoreCommonModelRequest
    ///     {
    ///         Reason = Merge.Client.Hris.ReasonEnum.GeneralCustomerRequest,
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task IgnoreCreateAsync(
        string modelId,
        IgnoreCommonModelRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "hris/v1/employees/ignore/{0}",
                        ValueConvert.ToPathParameterString(modelId)
                    ),
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new MergeApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Returns metadata for `Employee` POSTs.
    /// </summary>
    /// <example><code>
    /// await client.Hris.Employees.MetaPostRetrieveAsync();
    /// </code></example>
    public async Task<MetaResponse> MetaPostRetrieveAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "hris/v1/employees/meta/post",
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
                return JsonUtils.Deserialize<MetaResponse>(responseBody)!;
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
    }
}
