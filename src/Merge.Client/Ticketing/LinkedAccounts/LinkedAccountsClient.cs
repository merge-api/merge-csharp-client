using System.Text.Json;
using Merge.Client;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class LinkedAccountsClient
{
    private RawClient _client;

    public LinkedAccountsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// List linked accounts for your organization.
    /// </summary>
    public async Task<PaginatedAccountDetailsAndActionsList> ListAsync(
        LinkedAccountsListRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Category != null)
        {
            _query["category"] = request.Category;
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
            _query["include_duplicates"] = request.IncludeDuplicates;
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
            _query["page_size"] = request.PageSize;
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/ticketing/v1/linked-accounts",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedAccountDetailsAndActionsList>(responseBody);
        }
        throw new Exception();
    }
}
