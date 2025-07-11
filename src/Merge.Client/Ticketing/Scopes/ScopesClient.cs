using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public partial class ScopesClient
{
    private RawClient _client;

    internal ScopesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get the default permissions for Merge Common Models and fields across all Linked Accounts of a given category. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes).
    /// </summary>
    /// <example><code>
    /// await client.Ticketing.Scopes.DefaultScopesRetrieveAsync();
    /// </code></example>
    public async Task<CommonModelScopeApi> DefaultScopesRetrieveAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "ticketing/v1/default-scopes",
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
                return JsonUtils.Deserialize<CommonModelScopeApi>(responseBody)!;
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
    /// Get all available permissions for Merge Common Models and fields for a single Linked Account. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes).
    /// </summary>
    /// <example><code>
    /// await client.Ticketing.Scopes.LinkedAccountScopesRetrieveAsync();
    /// </code></example>
    public async Task<CommonModelScopeApi> LinkedAccountScopesRetrieveAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "ticketing/v1/linked-account-scopes",
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
                return JsonUtils.Deserialize<CommonModelScopeApi>(responseBody)!;
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
    /// Update permissions for any Common Model or field for a single Linked Account. Any Scopes not set in this POST request will inherit the default Scopes. [Learn more](https://help.merge.dev/en/articles/5950052-common-model-and-field-scopes)
    /// </summary>
    /// <example><code>
    /// await client.Ticketing.Scopes.LinkedAccountScopesCreateAsync(
    ///     new LinkedAccountCommonModelScopeDeserializerRequest
    ///     {
    ///         CommonModels =
    ///             new List&lt;Merge.Client.Ticketing.IndividualCommonModelScopeDeserializerRequest&gt;()
    ///             {
    ///                 new Merge.Client.Ticketing.IndividualCommonModelScopeDeserializerRequest
    ///                 {
    ///                     ModelName = "Employee",
    ///                     ModelPermissions = new Dictionary&lt;
    ///                         string,
    ///                         Merge.Client.Ticketing.ModelPermissionDeserializerRequest
    ///                     &gt;()
    ///                     {
    ///                         {
    ///                             "READ",
    ///                             new Merge.Client.Ticketing.ModelPermissionDeserializerRequest
    ///                             {
    ///                                 IsEnabled = true,
    ///                             }
    ///                         },
    ///                         {
    ///                             "WRITE",
    ///                             new Merge.Client.Ticketing.ModelPermissionDeserializerRequest
    ///                             {
    ///                                 IsEnabled = false,
    ///                             }
    ///                         },
    ///                     },
    ///                     FieldPermissions = new Merge.Client.Ticketing.FieldPermissionDeserializerRequest
    ///                     {
    ///                         EnabledFields = new List&lt;object&gt;() { "avatar", "home_location" },
    ///                         DisabledFields = new List&lt;object&gt;() { "work_location" },
    ///                     },
    ///                 },
    ///                 new Merge.Client.Ticketing.IndividualCommonModelScopeDeserializerRequest
    ///                 {
    ///                     ModelName = "Benefit",
    ///                     ModelPermissions = new Dictionary&lt;
    ///                         string,
    ///                         Merge.Client.Ticketing.ModelPermissionDeserializerRequest
    ///                     &gt;()
    ///                     {
    ///                         {
    ///                             "WRITE",
    ///                             new Merge.Client.Ticketing.ModelPermissionDeserializerRequest
    ///                             {
    ///                                 IsEnabled = false,
    ///                             }
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///     }
    /// );
    /// </code></example>
    public async Task<CommonModelScopeApi> LinkedAccountScopesCreateAsync(
        LinkedAccountCommonModelScopeDeserializerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "ticketing/v1/linked-account-scopes",
                    Body = request,
                    ContentType = "application/json",
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
                return JsonUtils.Deserialize<CommonModelScopeApi>(responseBody)!;
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
}
