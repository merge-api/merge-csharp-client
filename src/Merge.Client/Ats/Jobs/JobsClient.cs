using System.Text.Json;
using Merge.Client;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class JobsClient
{
    private RawClient _client;

    public JobsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Job` objects.
    /// </summary>
    public async Task<PaginatedJobList> ListAsync(JobsListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Code != null)
        {
            _query["code"] = request.Code;
        }
        if (request.CreatedAfter != null)
        {
            _query["created_after"] = request.CreatedAfter;
        }
        if (request.CreatedBefore != null)
        {
            _query["created_before"] = request.CreatedBefore;
        }
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData;
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.ModifiedAfter != null)
        {
            _query["modified_after"] = request.ModifiedAfter;
        }
        if (request.ModifiedBefore != null)
        {
            _query["modified_before"] = request.ModifiedBefore;
        }
        if (request.Offices != null)
        {
            _query["offices"] = request.Offices;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields;
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins;
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/ats/v1/jobs",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedJobList>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns a `Job` object with the given `id`.
    /// </summary>
    public async Task<Job> RetrieveAsync(string id, JobsRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand;
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.RemoteFields != null)
        {
            _query["remote_fields"] = request.RemoteFields;
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/ats/v1/jobs/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Job>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns a list of `ScreeningQuestion` objects.
    /// </summary>
    public async Task<PaginatedScreeningQuestionList> ScreeningQuestionsListAsync(
        string jobId,
        JobsScreeningQuestionsListRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData;
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/ats/v1/jobs/{jobId}/screening-questions",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedScreeningQuestionList>(responseBody);
        }
        throw new Exception();
    }
}
