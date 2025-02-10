using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public partial class PayrollRunsClient
{
    private RawClient _client;

    internal PayrollRunsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `PayrollRun` objects.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Hris.PayrollRuns.ListAsync(new PayrollRunsListRequest());
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<PaginatedPayrollRunList> ListAsync(
        PayrollRunsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
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
        if (request.EndedAfter != null)
        {
            _query["ended_after"] = request.EndedAfter.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.EndedBefore != null)
        {
            _query["ended_before"] = request.EndedBefore.Value.ToString(Constants.DateTimeFormat);
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
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields.Value.Stringify();
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        if (request.RunType != null)
        {
            _query["run_type"] = request.RunType.Value.Stringify();
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
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "hris/v1/payroll-runs",
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
                return JsonUtils.Deserialize<PaginatedPayrollRunList>(responseBody)!;
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
    /// Returns a `PayrollRun` object with the given `id`.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Hris.PayrollRuns.RetrieveAsync("id", new PayrollRunsRetrieveRequest());
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<PayrollRun> RetrieveAsync(
        string id,
        PayrollRunsRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = JsonUtils.Serialize(request.IncludeRemoteData.Value);
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
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = $"hris/v1/payroll-runs/{id}",
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
                return JsonUtils.Deserialize<PayrollRun>(responseBody)!;
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
