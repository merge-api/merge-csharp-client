using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

public partial class IssuesClient
{
    private RawClient _client;

    internal IssuesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets all issues for Organization.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.Issues.ListAsync(new IssuesListRequest());
    /// </code></example>
    public async Task<PaginatedIssueList> ListAsync(
        IssuesListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.AccountToken != null)
        {
            _query["account_token"] = request.AccountToken;
        }
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.EndDate != null)
        {
            _query["end_date"] = request.EndDate;
        }
        if (request.EndUserOrganizationName != null)
        {
            _query["end_user_organization_name"] = request.EndUserOrganizationName;
        }
        if (request.FirstIncidentTimeAfter != null)
        {
            _query["first_incident_time_after"] = request.FirstIncidentTimeAfter.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.FirstIncidentTimeBefore != null)
        {
            _query["first_incident_time_before"] = request.FirstIncidentTimeBefore.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.IncludeMuted != null)
        {
            _query["include_muted"] = request.IncludeMuted;
        }
        if (request.IntegrationName != null)
        {
            _query["integration_name"] = request.IntegrationName;
        }
        if (request.LastIncidentTimeAfter != null)
        {
            _query["last_incident_time_after"] = request.LastIncidentTimeAfter.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.LastIncidentTimeBefore != null)
        {
            _query["last_incident_time_before"] = request.LastIncidentTimeBefore.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.LinkedAccountId != null)
        {
            _query["linked_account_id"] = request.LinkedAccountId;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.Value.ToString();
        }
        if (request.StartDate != null)
        {
            _query["start_date"] = request.StartDate;
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "accounting/v1/issues",
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
                return JsonUtils.Deserialize<PaginatedIssueList>(responseBody)!;
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
    /// Get a specific issue.
    /// </summary>
    /// <example><code>
    /// await client.Accounting.Issues.RetrieveAsync("id");
    /// </code></example>
    public async Task<Issue> RetrieveAsync(
        string id,
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
                    Path = string.Format(
                        "accounting/v1/issues/{0}",
                        ValueConvert.ToPathParameterString(id)
                    ),
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
                return JsonUtils.Deserialize<Issue>(responseBody)!;
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
