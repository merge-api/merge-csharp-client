using System.Text.Json;
using Merge.Client;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class DependentsClient
{
    private RawClient _client;

    public DependentsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Dependent` objects.
    /// </summary>
    public async Task<PaginatedDependentList> ListAsync(DependentsListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
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
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData;
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.IncludeSensitiveFields != null)
        {
            _query["include_sensitive_fields"] = request.IncludeSensitiveFields;
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
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/hris/v1/dependents",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedDependentList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a `Dependent` object with the given `id`.
    /// </summary>
    public async Task<Dependent> RetrieveAsync(string id, DependentsRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData;
        }
        if (request.IncludeSensitiveFields != null)
        {
            _query["include_sensitive_fields"] = request.IncludeSensitiveFields;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/hris/v1/dependents/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Dependent>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
