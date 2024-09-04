using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

public partial class ScopesClient
{
    private RawClient _client;

    internal ScopesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Hris.Scopes.DefaultScopesRetrieveAsync();
    /// </code>
    /// </example>
    public async Task<CommonModelScopeApi> DefaultScopesRetrieveAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "hris/v1/default-scopes",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CommonModelScopeApi>(responseBody)!;
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

    /// <summary>
    /// Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes).
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Hris.Scopes.LinkedAccountScopesRetrieveAsync();
    /// </code>
    /// </example>
    public async Task<CommonModelScopeApi> LinkedAccountScopesRetrieveAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Get,
                Path = "hris/v1/linked-account-scopes",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CommonModelScopeApi>(responseBody)!;
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

    /// <summary>
    /// Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/8828211-common-model-and-field-scopes)
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Hris.Scopes.LinkedAccountScopesCreateAsync(
    ///     new LinkedAccountCommonModelScopeDeserializerRequest
    ///     {
    ///         CommonModels = new List<Merge.Client.Hris.IndividualCommonModelScopeDeserializerRequest>()
    ///         {
    ///             new Merge.Client.Hris.IndividualCommonModelScopeDeserializerRequest
    ///             {
    ///                 ModelName = "Employee",
    ///                 ModelPermissions = new Dictionary<
    ///                     string,
    ///                     Merge.Client.Hris.ModelPermissionDeserializerRequest
    ///                 >()
    ///                 {
    ///                     {
    ///                         "READ",
    ///                         new Merge.Client.Hris.ModelPermissionDeserializerRequest
    ///                         {
    ///                             IsEnabled = true,
    ///                         }
    ///                     },
    ///                     {
    ///                         "WRITE",
    ///                         new Merge.Client.Hris.ModelPermissionDeserializerRequest
    ///                         {
    ///                             IsEnabled = false,
    ///                         }
    ///                     },
    ///                 },
    ///             },
    ///             new Merge.Client.Hris.IndividualCommonModelScopeDeserializerRequest
    ///             {
    ///                 ModelName = "Benefit",
    ///                 ModelPermissions = new Dictionary<
    ///                     string,
    ///                     Merge.Client.Hris.ModelPermissionDeserializerRequest
    ///                 >()
    ///                 {
    ///                     {
    ///                         "WRITE",
    ///                         new Merge.Client.Hris.ModelPermissionDeserializerRequest
    ///                         {
    ///                             IsEnabled = false,
    ///                         }
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<CommonModelScopeApi> LinkedAccountScopesCreateAsync(
        LinkedAccountCommonModelScopeDeserializerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "hris/v1/linked-account-scopes",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CommonModelScopeApi>(responseBody)!;
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
