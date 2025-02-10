using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

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
    /// <example>
    /// <code>
    /// await client.Accounting.AuditTrail.ListAsync(new AuditTrailListRequest());
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<PaginatedAuditLogEventList> ListAsync(
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
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "accounting/v1/audit-trail",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
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
            responseBody
        );
    }
}
