using System.Net.Http;
using System.Text.Json;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

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
    public async Task<PaginatedAuditLogEventList> ListAsync(
        AuditTrailListRequest request,
        RequestOptions? options = null
    )
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
            _query["page_size"] = request.PageSize.ToString();
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
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "hris/v1/audit-trail",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PaginatedAuditLogEventList>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        throw new MergeApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
