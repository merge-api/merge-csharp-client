using System.Text.Json;
using Merge.Client;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class ScopesClient
{
    private RawClient _client;

    public ScopesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
    /// </summary>
    public async Task<CommonModelScopeApi> DefaultScopesRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest { Method = HttpMethod.Get, Path = "/hris/v1/default-scopes" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CommonModelScopeApi>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
    /// </summary>
    public async Task<CommonModelScopeApi> LinkedAccountScopesRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/hris/v1/linked-account-scopes"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CommonModelScopeApi>(responseBody);
        }
        throw new Exception();
    }

    /// <summary>
    /// Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes)
    /// </summary>
    public async Task<CommonModelScopeApi> LinkedAccountScopesCreateAsync(
        LinkedAccountCommonModelScopeDeserializerRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/hris/v1/linked-account-scopes",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<CommonModelScopeApi>(responseBody);
        }
        throw new Exception();
    }
}
