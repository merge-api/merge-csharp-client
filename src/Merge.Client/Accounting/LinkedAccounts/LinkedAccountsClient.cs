using System.Net.Http;
using System.Text.Json;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

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
    public async Task<PaginatedAccountDetailsAndActionsList> ListAsync(
        LinkedAccountsListRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Category != null)
        {
            _query["category"] = JsonSerializer.Serialize(request.Category.Value);
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
            _query["include_duplicates"] = request.IncludeDuplicates.ToString();
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
            _query["page_size"] = request.PageSize.ToString();
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "accounting/v1/linked-accounts",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PaginatedAccountDetailsAndActionsList>(responseBody)!;
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
