using System.Text.Json;
using Merge.Client;
using Merge.Client.Accounting;

#nullable enable

namespace Merge.Client.Accounting;

public class AuditTrailClient
{
    private RawClient _client;

    public AuditTrailClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets a list of audit trail events.
    /// </summary>
    public async Task<PaginatedAuditLogEventList> ListAsync(AuditTrailListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.EndDate != null)
        {
            _query["end_date"] = request.EndDate;
        }
        if (request.EventType != null)
        {
            _query["event_type"] = request.EventType;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize;
        }
        if (request.StartDate != null)
        {
            _query["start_date"] = request.StartDate;
        }
        if (request.UserEmail != null)
        {
            _query["user_email"] = request.UserEmail;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/accounting/v1/audit-trail",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedAuditLogEventList>(responseBody);
        }
        throw new Exception();
    }
}
