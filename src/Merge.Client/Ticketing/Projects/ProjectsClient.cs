using System.Text.Json;
using Merge.Client;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class ProjectsClient
{
    private RawClient _client;

    public ProjectsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Project` objects.
    /// </summary>
    public async Task<PaginatedProjectList> ListAsync(ProjectsListRequest request)
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
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "ticketing/v1/projects",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedProjectList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a `Project` object with the given `id`.
    /// </summary>
    public async Task<Project> RetrieveAsync(string id, ProjectsRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"ticketing/v1/projects/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Project>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a list of `User` objects.
    /// </summary>
    public async Task<PaginatedUserList> UsersListAsync(
        string parentId,
        ProjectsUsersListRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.Expand != null)
        {
            _query["expand"] = JsonSerializer.Serialize(request.Expand.Value);
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData.ToString();
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"ticketing/v1/projects/{parentId}/users",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedUserList>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
