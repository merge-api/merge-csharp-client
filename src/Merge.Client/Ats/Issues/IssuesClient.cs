using System.Net.Http;
using System.Text.Json;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public class IssuesClient
{
    private RawClient _client;

    public IssuesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets all issues for Organization.
    /// </summary>
    public async Task<PaginatedIssueList> ListAsync(
        IssuesListRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
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
            _query["page_size"] = request.PageSize.ToString();
        }
        if (request.StartDate != null)
        {
            _query["start_date"] = request.StartDate;
        }
        if (request.Status != null)
        {
            _query["status"] = JsonSerializer.Serialize(request.Status.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "ats/v1/issues",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PaginatedIssueList>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Get a specific issue.
    /// </summary>
    public async Task<Issue> RetrieveAsync(string id, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = $"ats/v1/issues/{id}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Issue>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
