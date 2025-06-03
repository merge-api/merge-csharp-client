using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Merge;
using Merge.Core;
using Merge.Hris;

namespace Merge.Hris.BankInfo;

public partial class BankInfoClient
{
    private RawClient _client;

    internal BankInfoClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `BankInfo` objects.
    /// </summary>
    private async Task<PaginatedBankInfoList> ListInternalAsync(
        BankInfoListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
                _query["expand"] = request.Expand.Select(_value => _value.ToString()).ToList();
                if (request.AccountType != null)
                {
                    _query["account_type"] = request.AccountType.Value.Stringify();
                }
                if (request.BankName != null)
                {
                    _query["bank_name"] = request.BankName;
                }
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
                if (request.EmployeeId != null)
                {
                    _query["employee_id"] = request.EmployeeId;
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
                if (request.OrderBy != null)
                {
                    _query["order_by"] = request.OrderBy.Value.Stringify();
                }
                if (request.PageSize != null)
                {
                    _query["page_size"] = request.PageSize.Value.ToString();
                }
                if (request.RemoteFields != null)
                {
                    _query["remote_fields"] = request.RemoteFields.ToString();
                }
                if (request.RemoteId != null)
                {
                    _query["remote_id"] = request.RemoteId;
                }
                if (request.ShowEnumOrigins != null)
                {
                    _query["show_enum_origins"] = request.ShowEnumOrigins.ToString();
                }
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Get,
                            Path = "hris/v1/bank-info",
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
                        return JsonUtils.Deserialize<PaginatedBankInfoList>(responseBody)!;
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
    /// Returns a list of `BankInfo` objects.
    /// </summary>
    /// <example><code>
    /// await client.Hris.BankInfo.ListAsync(new BankInfoListRequest());
    /// </code></example>
    public async Task<Pager<Merge.Hris.BankInfo>> ListAsync(
        BankInfoListRequest request,
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
                    BankInfoListRequest,
                    RequestOptions?,
                    PaginatedBankInfoList,
                    string?,
                    Merge.Hris.BankInfo
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
    /// Returns a `BankInfo` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Hris.BankInfo.RetrieveAsync("id", new BankInfoRetrieveRequest());
    /// </code></example>
    public async Task<Merge.Hris.BankInfo> RetrieveAsync(
        string id,
        BankInfoRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return await _client
            .Options.ExceptionHandler.TryCatchAsync(async () =>
            {
                var _query = new Dictionary<string, object>();
                _query["expand"] = request.Expand.Select(_value => _value.ToString()).ToList();
                if (request.IncludeRemoteData != null)
                {
                    _query["include_remote_data"] = JsonUtils.Serialize(
                        request.IncludeRemoteData.Value
                    );
                }
                if (request.IncludeShellData != null)
                {
                    _query["include_shell_data"] = JsonUtils.Serialize(
                        request.IncludeShellData.Value
                    );
                }
                if (request.RemoteFields != null)
                {
                    _query["remote_fields"] = request.RemoteFields.ToString();
                }
                if (request.ShowEnumOrigins != null)
                {
                    _query["show_enum_origins"] = request.ShowEnumOrigins.ToString();
                }
                var response = await _client
                    .SendRequestAsync(
                        new JsonRequest
                        {
                            BaseUrl = _client.Options.Environment.Api,
                            Method = HttpMethod.Get,
                            Path = string.Format(
                                "hris/v1/bank-info/{0}",
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
                        return JsonUtils.Deserialize<Merge.Hris.BankInfo>(responseBody)!;
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
