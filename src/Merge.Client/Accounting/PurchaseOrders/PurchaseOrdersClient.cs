using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class PurchaseOrdersClient
{
    private RawClient _client;

    public PurchaseOrdersClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `PurchaseOrder` objects.
    /// </summary>
    public async Task<PaginatedPurchaseOrderList> ListAsync(PurchaseOrdersListRequest request)
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
        if (request.IssueDateAfter != null)
        {
            _query["issue_date_after"] = request.IssueDateAfter.Value.ToString("o0");
        }
        if (request.IssueDateBefore != null)
        {
            _query["issue_date_before"] = request.IssueDateBefore.Value.ToString("o0");
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
                Path = "accounting/v1/purchase-orders",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedPurchaseOrderList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a `PurchaseOrder` object with the given values.
    /// </summary>
    public async Task<PurchaseOrderResponse> CreateAsync(PurchaseOrderEndpointRequest request)
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
                Path = "accounting/v1/purchase-orders",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PurchaseOrderResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a `PurchaseOrder` object with the given `id`.
    /// </summary>
    public async Task<PurchaseOrder> RetrieveAsync(string id, PurchaseOrdersRetrieveRequest request)
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
                Path = $"accounting/v1/purchase-orders/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PurchaseOrder>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns metadata for `PurchaseOrder` POSTs.
    /// </summary>
    public async Task<MetaResponse> MetaPostRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "accounting/v1/purchase-orders/meta/post"
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
