using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

public partial class AuditTrailClient
{
    private RawClient _client;

    internal AuditTrailClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets a list of audit trail events.
    /// </summary>
    private async Task<PaginatedAuditLogEventList> ListInternalAsync(
        AuditTrailListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
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
            _query["page_size"] = request.PageSize.Value.ToString();
        }
        if (request.StartDate != null)
        {
            _query["start_date"] = request.StartDate;
        }
        if (request.UserEmail != null)
        {
            _query["user_email"] = request.UserEmail;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Get,
                    Path = "filestorage/v1/audit-trail",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<PaginatedAuditLogEventList>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new MergeException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new MergeApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Gets a list of audit trail events.
    /// </summary>
    /// <example><code>
    /// await client.FileStorage.AuditTrail.ListAsync(new AuditTrailListRequest());
    /// </code></example>
    public async Task<Pager<AuditLogEvent>> ListAsync(
        AuditTrailListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            AuditTrailListRequest,
            RequestOptions?,
            PaginatedAuditLogEventList,
            string?,
            AuditLogEvent
        >
            .CreateInstanceAsync(
                request,
                options,
                ListInternalAsync,
                (request, cursor) =>
                {
                    request.Cursor = cursor;
                },
                response => response?.Next,
                response => response?.Results?.ToList(),
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }
}
