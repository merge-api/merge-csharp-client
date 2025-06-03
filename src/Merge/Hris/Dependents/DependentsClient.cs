using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge;
using Merge.Core;
using Merge.Hris;

namespace Merge.Hris.Dependents;

public partial class DependentsClient
{
    private RawClient _client;

    internal DependentsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Dependent` objects.
    /// </summary>
    private async Task<PaginatedDependentList> ListInternalAsync(
        DependentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
                if (request.CreatedAfter != null)
                {
                    _query["created_after"] = request.CreatedAfter.Value.ToString(
                        Constants.DateTimeFormat
                    );
                }
                if (request.CreatedBefore != null)
                {
                    _query["created_before"] = request.CreatedBefore.Value.ToString(
                        Constants.DateTimeFormat
                    );
                }
                if (request.Cursor != null)
                {
                    _query["cursor"] = request.Cursor;
                }
                if (request.IncludeDeletedData != null)
                {
                    _query["include_deleted_data"] = JsonUtils.Serialize(
                        request.IncludeDeletedData.Value
                    );
                }
                if (request.IncludeRemoteData != null)
                {
                    _query["include_remote_data"] = JsonUtils.Serialize(
                        request.IncludeRemoteData.Value
                    );
                }
                if (request.IncludeSensitiveFields != null)
                {
                    _query["include_sensitive_fields"] = JsonUtils.Serialize(
                        request.IncludeSensitiveFields.Value
                    );
                }
                if (request.IncludeShellData != null)
                {
                    _query["include_shell_data"] = JsonUtils.Serialize(
                        request.IncludeShellData.Value
                    );
                }
                if (request.ModifiedAfter != null)
                {
                    _query["modified_after"] = request.ModifiedAfter.Value.ToString(
                        Constants.DateTimeFormat
                    );
                }
                if (request.ModifiedBefore != null)
                {
                    _query["modified_before"] = request.ModifiedBefore.Value.ToString(
                        Constants.DateTimeFormat
                    );
                }
                if (request.PageSize != null)
                {
                    _query["page_size"] = request.PageSize.Value.ToString();
                }
                if (request.RemoteId != null)
                {
                    _query["remote_id"] = request.RemoteId;
                }
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Get,
                            Path = "hris/v1/dependents",
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
                        return JsonUtils.Deserialize<PaginatedDependentList>(responseBody)!;
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
            })
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Returns a list of `Dependent` objects.
    /// </summary>
    /// <example><code>
    /// await client.Hris.Dependents.ListAsync(new DependentsListRequest());
    /// </code></example>
    public async Task<Pager<Dependent>> ListAsync(
        DependentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                if (request is not null)
                {
                    request = request with { };
                }
                var pager = await CursorPager<
                    DependentsListRequest,
                    RequestOptions?,
                    PaginatedDependentList,
                    string?,
                    Dependent
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
            })
            .ConfigureAwait(false);
    }

    /// <summary>
    /// Returns a `Dependent` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Hris.Dependents.RetrieveAsync("id", new DependentsRetrieveRequest());
    /// </code></example>
    public async Task<Dependent> RetrieveAsync(
        string id,
        DependentsRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
                if (request.IncludeRemoteData != null)
                {
                    _query["include_remote_data"] = JsonUtils.Serialize(
                        request.IncludeRemoteData.Value
                    );
                }
                if (request.IncludeSensitiveFields != null)
                {
                    _query["include_sensitive_fields"] = JsonUtils.Serialize(
                        request.IncludeSensitiveFields.Value
                    );
                }
                if (request.IncludeShellData != null)
                {
                    _query["include_shell_data"] = JsonUtils.Serialize(
                        request.IncludeShellData.Value
                    );
                }
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Get,
                            Path = string.Format(
                                "hris/v1/dependents/{0}",
                                ValueConvert.ToPathParameterString(id)
                            ),
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
                        return JsonUtils.Deserialize<Dependent>(responseBody)!;
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
            })
            .ConfigureAwait(false);
    }
}
