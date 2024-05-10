using System.Text.Json;
using Merge.Client;
using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class ApplicationsClient
{
    private RawClient _client;

    public ApplicationsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Application` objects.
    /// </summary>
    public async Task<PaginatedApplicationList> ListAsync(ApplicationsListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.CandidateId != null)
        {
            _query["candidate_id"] = request.CandidateId;
        }
        if (request.CreatedAfter != null)
        {
            _query["created_after"] = request.CreatedAfter;
        }
        if (request.CreatedBefore != null)
        {
            _query["created_before"] = request.CreatedBefore;
        }
        if (request.CreditedToId != null)
        {
            _query["credited_to_id"] = request.CreditedToId;
        }
        if (request.CurrentStageId != null)
        {
            _query["current_stage_id"] = request.CurrentStageId;
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
        if (request.JobId != null)
        {
            _query["job_id"] = request.JobId;
        }
        if (request.ModifiedAfter != null)
        {
            _query["modified_after"] = request.ModifiedAfter;
        }
        if (request.ModifiedBefore != null)
        {
            _query["modified_before"] = request.ModifiedBefore;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        if (request.RejectReasonId != null)
        {
            _query["reject_reason_id"] = request.RejectReasonId;
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        if (request.Source != null)
        {
            _query["source"] = request.Source;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/ats/v1/applications",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedApplicationList>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Creates an `Application` object with the given values.
    /// </summary>
    public async Task<ApplicationResponse> CreateAsync(ApplicationEndpointRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = request.IsDebugMode;
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = request.RunAsync;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/ats/v1/applications",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ApplicationResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns an `Application` object with the given `id`.
    /// </summary>
    public async Task<Application> RetrieveAsync(string id, ApplicationsRetrieveRequest request)
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
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/ats/v1/applications/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Application>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Updates the `current_stage` field of an `Application` object
    /// </summary>
    public async Task<ApplicationResponse> ChangeStageCreateAsync(
        string id,
        UpdateApplicationStageRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = request.IsDebugMode;
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = request.RunAsync;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/ats/v1/applications/{id}/change-stage",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ApplicationResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns metadata for `Application` POSTs.
    /// </summary>
    public async Task<MetaResponse> MetaPostRetrieveAsync(
        ApplicationsMetaPostRetrieveRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.ApplicationRemoteTemplateId != null)
        {
            _query["application_remote_template_id"] = request.ApplicationRemoteTemplateId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/ats/v1/applications/meta/post",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MetaResponse>(responseBody);
        }
        throw new Exception();
    }
}
