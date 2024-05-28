using System.Text.Json;
using Merge.Client;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class CommentsClient
{
    private RawClient _client;

    public CommentsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Comment` objects.
    /// </summary>
    public async Task<PaginatedCommentList> ListAsync(CommentsListRequest request)
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
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        if (request.RemoteCreatedAfter != null)
        {
            _query["remote_created_after"] = request.RemoteCreatedAfter;
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        if (request.TicketId != null)
        {
            _query["ticket_id"] = request.TicketId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/ticketing/v1/comments",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedCommentList>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Creates a `Comment` object with the given values.
    /// </summary>
    public async Task<CommentResponse> CreateAsync(CommentEndpointRequest request)
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
                Path = "/ticketing/v1/comments",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CommentResponse>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns a `Comment` object with the given `id`.
    /// </summary>
    public async Task<Comment> RetrieveAsync(string id, CommentsRetrieveRequest request)
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
                Path = $"/ticketing/v1/comments/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Comment>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Returns metadata for `Comment` POSTs.
    /// </summary>
    public async Task<MetaResponse> MetaPostRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/ticketing/v1/comments/meta/post"
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
