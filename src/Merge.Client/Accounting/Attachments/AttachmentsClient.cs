using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class AttachmentsClient
{
    private RawClient _client;

    public AttachmentsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `AccountingAttachment` objects.
    /// </summary>
    public async Task<PaginatedAccountingAttachmentList> ListAsync(AttachmentsListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.CompanyId != null)
        {
            _query["company_id"] = request.CompanyId;
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
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/accounting/v1/attachments",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedAccountingAttachmentList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates an `AccountingAttachment` object with the given values.
    /// </summary>
    public async Task<AccountingAttachmentResponse> CreateAsync(
        AccountingAttachmentEndpointRequest request
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
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/accounting/v1/attachments",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AccountingAttachmentResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns an `AccountingAttachment` object with the given `id`.
    /// </summary>
    public async Task<AccountingAttachment> RetrieveAsync(
        string id,
        AttachmentsRetrieveRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/accounting/v1/attachments/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<AccountingAttachment>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns metadata for `AccountingAttachment` POSTs.
    /// </summary>
    public async Task<MetaResponse> MetaPostRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/accounting/v1/attachments/meta/post"
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
