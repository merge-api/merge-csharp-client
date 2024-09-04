using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ticketing;

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
    /// await client.Ticketing.LinkToken.CreateAsync(
    ///     new EndUserDetailsRequest
    ///     {
    ///         EndUserEmailAddress = "example@gmail.com",
    ///         EndUserOrganizationName = "Test Organization",
    ///         EndUserOriginId = "12345",
    ///         Categories = new List<Merge.Client.Ticketing.CategoriesEnum>()
    ///         {
    ///             Merge.Client.Ticketing.CategoriesEnum.Hris,
    ///             Merge.Client.Ticketing.CategoriesEnum.Ats,
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<LinkToken> CreateAsync(
        EndUserDetailsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.BaseUrl,
                Method = HttpMethod.Post,
                Path = "ticketing/v1/link-token",
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
