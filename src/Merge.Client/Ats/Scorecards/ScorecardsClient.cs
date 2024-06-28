using System.Text.Json;
using Merge.Client;
using Merge.Client.Ats;

#nullable enable

namespace Merge.Client.Ats;

public class ScorecardsClient
{
    private RawClient _client;

    public ScorecardsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Scorecard` objects.
    /// </summary>
    public async Task<PaginatedScorecardList> ListAsync(ScorecardsListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.ApplicationId != null)
        {
            _query["application_id"] = request.ApplicationId;
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
        if (request.InterviewId != null)
        {
            _query["interview_id"] = request.InterviewId;
        }
        if (request.InterviewerId != null)
        {
            _query["interviewer_id"] = request.InterviewerId;
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
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "ats/v1/scorecards",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedScorecardList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a `Scorecard` object with the given `id`.
    /// </summary>
    public async Task<Scorecard> RetrieveAsync(string id, ScorecardsRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Expand != null)
        {
            _query["expand"] = JsonSerializer.Serialize(request.Expand.Value);
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
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"ats/v1/scorecards/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Scorecard>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
