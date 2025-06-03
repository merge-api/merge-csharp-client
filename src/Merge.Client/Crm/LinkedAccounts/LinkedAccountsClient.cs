using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public partial class LinkedAccountsClient
{
    private RawClient _client;

    internal LinkedAccountsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// List linked accounts for your organization.
    /// </summary>
    private async Task<PaginatedAccountDetailsAndActionsList> ListInternalAsync(
        LinkedAccountsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Category != null)
        {
            _query["category"] = request.Category.Value.Stringify();
        }
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.EndUserEmailAddress != null)
        {
            _query["end_user_email_address"] = request.EndUserEmailAddress;
        }
        if (request.EndUserOrganizationName != null)
        {
            _query["end_user_organization_name"] = request.EndUserOrganizationName;
        }
        if (request.EndUserOriginId != null)
        {
            _query["end_user_origin_id"] = request.EndUserOriginId;
        }
        if (request.EndUserOriginIds != null)
        {
            _query["end_user_origin_ids"] = request.EndUserOriginIds;
        }
        if (request.Id != null)
        {
            _query["id"] = request.Id;
        }
        if (request.Ids != null)
        {
            _query["ids"] = request.Ids;
        }
        if (request.IncludeDuplicates != null)
        {
            _query["include_duplicates"] = JsonUtils.Serialize(request.IncludeDuplicates.Value);
        }
        if (request.IntegrationName != null)
        {
            _query["integration_name"] = request.IntegrationName;
        }
        if (request.IsTestAccount != null)
        {
            _query["is_test_account"] = request.IsTestAccount;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.Value.ToString();
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.Api,
                    Method = HttpMethod.Get,
                    Path = "crm/v1/linked-accounts",
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
                return JsonUtils.Deserialize<PaginatedAccountDetailsAndActionsList>(responseBody)!;
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
    /// List linked accounts for your organization.
    /// </summary>
    /// <example><code>
    /// await client.Crm.LinkedAccounts.ListAsync(new LinkedAccountsListRequest());
    /// </code></example>
    public async Task<Pager<AccountDetailsAndActions>> ListAsync(
        LinkedAccountsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            LinkedAccountsListRequest,
            RequestOptions?,
            PaginatedAccountDetailsAndActionsList,
            string?,
            AccountDetailsAndActions
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
