using System.Text.Json;
using Merge.Client;
using Merge.Client.Filestorage;

namespace Merge.Client.Filestorage;

public class IssuesClient
{
    private RawClient _client;

    public IssuesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets issues.
    /// </summary>
    public async Task<PaginatedIssueList> ListAsync(IssuesListRequest request)
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
            _query["first_incident_time_after"] = request.FirstIncidentTimeAfter;
        }
        if (request.FirstIncidentTimeBefore != null)
        {
            _query["first_incident_time_before"] = request.FirstIncidentTimeBefore;
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
            _query["last_incident_time_after"] = request.LastIncidentTimeAfter;
        }
        if (request.LastIncidentTimeBefore != null)
        {
            _query["last_incident_time_before"] = request.LastIncidentTimeBefore;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        if (request.StartDate != null)
        {
            _query["start_date"] = request.StartDate;
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/filestorage/v1/issues",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedIssueList>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Get a specific issue.
    /// </summary>
    public async Task<Issue> RetrieveAsync(string id)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/filestorage/v1/issues/{id}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Issue>(responseBody);
        }
        throw new Exception();
    }
}
