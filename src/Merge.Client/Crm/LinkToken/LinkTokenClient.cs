using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

namespace Merge.Client.Crm;

public partial class LinkTokenClient
{
    private RawClient _client;

    internal LinkTokenClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a link token to be used when linking a new end user.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Crm.LinkToken.CreateAsync(
    ///     new EndUserDetailsRequest
    ///     {
    ///         EndUserEmailAddress = "example@gmail.com",
    ///         EndUserOrganizationName = "Test Organization",
    ///         EndUserOriginId = "12345",
    ///         Categories = new List&lt;Merge.Client.Crm.CategoriesEnum&gt;()
    ///         {
    ///             Merge.Client.Crm.CategoriesEnum.Hris,
    ///             Merge.Client.Crm.CategoriesEnum.Ats,
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task<LinkToken> CreateAsync(
        EndUserDetailsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .MakeRequestAsync(
                new RawClient.JsonApiRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "crm/v1/link-token",
                    Body = request,
                    ContentType = "application/json",
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
                return JsonUtils.Deserialize<LinkToken>(responseBody)!;
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
