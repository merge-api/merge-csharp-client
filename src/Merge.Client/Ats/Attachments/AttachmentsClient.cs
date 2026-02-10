using System.Text.Json;
using Merge.Client.Core;

namespace Merge.Client.Ats;

public partial class AttachmentsClient
{
    private RawClient _client;

    internal AttachmentsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Attachment` objects.
    /// </summary>
    private async System.Threading.Tasks.Task<PaginatedAttachmentList> ListInternalAsync(
        AttachmentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["expand"] = request.Expand.Select(_value => _value.ToString()).ToList();
        if (request.CandidateId != null)
        {
            _query["candidate_id"] = request.CandidateId;
        }
        if (request.CreatedAfter != null)
        {
            _query["created_after"] = request.CreatedAfter.Value.ToString(Constants.DateTimeFormat);
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
            _query["include_deleted_data"] = JsonUtils.Serialize(request.IncludeDeletedData.Value);
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = JsonUtils.Serialize(request.IncludeRemoteData.Value);
        }
        if (request.IncludeShellData != null)
        {
            _query["include_shell_data"] = JsonUtils.Serialize(request.IncludeShellData.Value);
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
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "ats/v1/attachments",
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
                return JsonUtils.Deserialize<PaginatedAttachmentList>(responseBody)!;
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
    /// Returns a list of `Attachment` objects.
    /// </summary>
    /// <example><code>
    /// await client.Ats.Attachments.ListAsync(
    ///     new Merge.Client.Ats.AttachmentsListRequest
    ///     {
    ///         CandidateId = "candidate_id",
    ///         CreatedAfter = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         CreatedBefore = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         Cursor = "cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw",
    ///         IncludeDeletedData = true,
    ///         IncludeRemoteData = true,
    ///         IncludeShellData = true,
    ///         ModifiedAfter = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         ModifiedBefore = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         PageSize = 1,
    ///         RemoteFields = "attachment_type",
    ///         RemoteId = "remote_id",
    ///         ShowEnumOrigins = "attachment_type",
    ///     }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<Pager<Attachment>> ListAsync(
        AttachmentsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            AttachmentsListRequest,
            RequestOptions?,
            PaginatedAttachmentList,
            string?,
            Attachment
        >
            .CreateInstanceAsync(
                request,
                options,
                ListInternalAsync,
                (request, cursor) =>
                {
                    request.Cursor = cursor;
                },
                response => response.Next,
                response => response.Results?.ToList(),
                cancellationToken
            )
            .ConfigureAwait(false);
        return pager;
    }

    /// <summary>
    /// Creates an `Attachment` object with the given values.
    /// </summary>
    /// <example><code>
    /// await client.Ats.Attachments.CreateAsync(
    ///     new AttachmentEndpointRequest
    ///     {
    ///         IsDebugMode = true,
    ///         RunAsync = true,
    ///         Model = new Merge.Client.Ats.AttachmentRequest(),
    ///         RemoteUserId = "remote_user_id",
    ///     }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<AttachmentResponse> CreateAsync(
        AttachmentEndpointRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = JsonUtils.Serialize(request.IsDebugMode.Value);
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = JsonUtils.Serialize(request.RunAsync.Value);
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "ats/v1/attachments",
                    Body = request,
                    Query = _query,
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
                return JsonUtils.Deserialize<AttachmentResponse>(responseBody)!;
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
    /// Returns an `Attachment` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Ats.Attachments.RetrieveAsync(
    ///     "id",
    ///     new Merge.Client.Ats.AttachmentsRetrieveRequest
    ///     {
    ///         IncludeRemoteData = true,
    ///         IncludeShellData = true,
    ///         RemoteFields = "attachment_type",
    ///         ShowEnumOrigins = "attachment_type",
    ///     }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<Attachment> RetrieveAsync(
        string id,
        AttachmentsRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["expand"] = request.Expand.Select(_value => _value.ToString()).ToList();
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = JsonUtils.Serialize(request.IncludeRemoteData.Value);
        }
        if (request.IncludeShellData != null)
        {
            _query["include_shell_data"] = JsonUtils.Serialize(request.IncludeShellData.Value);
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
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "ats/v1/attachments/{0}",
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
                return JsonUtils.Deserialize<Attachment>(responseBody)!;
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
    /// Returns metadata for `Attachment` POSTs.
    /// </summary>
    /// <example><code>
    /// await client.Ats.Attachments.MetaPostRetrieveAsync();
    /// </code></example>
    public async System.Threading.Tasks.Task<MetaResponse> MetaPostRetrieveAsync(
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
                    Path = "ats/v1/attachments/meta/post",
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
                return JsonUtils.Deserialize<MetaResponse>(responseBody)!;
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
