using System.Text.Json;
using Merge.Client;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

public class AttachmentsClient
{
    private RawClient _client;

    public AttachmentsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Attachment` objects.
    /// </summary>
    public async Task<PaginatedAttachmentList> ListAsync(AttachmentsListRequest request)
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
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand.ToString();
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
        if (request.RemoteCreatedAfter != null)
        {
            _query["remote_created_after"] = request.RemoteCreatedAfter.Value.ToString("o0");
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
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "ticketing/v1/attachments",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedAttachmentList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates an `Attachment` object with the given values.
    /// </summary>
    public async Task<TicketingAttachmentResponse> CreateAsync(
        TicketingAttachmentEndpointRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = request.IsDebugMode.ToString();
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = request.RunAsync.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "ticketing/v1/attachments",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<TicketingAttachmentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns an `Attachment` object with the given `id`.
    /// </summary>
    public async Task<Attachment> RetrieveAsync(string id, AttachmentsRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand.ToString();
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"ticketing/v1/attachments/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<Attachment>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns an `Attachment` object with the given `id`.
    /// </summary>
    public async void DownloadRetrieveAsync(string id, AttachmentsDownloadRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.MimeType != null)
        {
            _query["mime_type"] = request.MimeType;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"ticketing/v1/attachments/{id}/download",
                Query = _query
            }
        );
    }

    /// <summary>
    /// Returns metadata for `TicketingAttachment` POSTs.
    /// </summary>
    public async Task<MetaResponse> MetaPostRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "ticketing/v1/attachments/meta/post"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MetaResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
