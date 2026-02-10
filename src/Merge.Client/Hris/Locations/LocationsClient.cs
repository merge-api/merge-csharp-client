using System.Text.Json;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public partial class LocationsClient
{
    private RawClient _client;

    internal LocationsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `Location` objects.
    /// </summary>
    private async System.Threading.Tasks.Task<PaginatedLocationList> ListInternalAsync(
        LocationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
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
        if (request.LocationType != null)
        {
            _query["location_type"] = request.LocationType.Value.Stringify();
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
            _query["remote_fields"] = request.RemoteFields.Value.Stringify();
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = "hris/v1/locations",
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
                return JsonUtils.Deserialize<PaginatedLocationList>(responseBody)!;
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
    /// Returns a list of `Location` objects.
    /// </summary>
    /// <example><code>
    /// await client.Hris.Locations.ListAsync(
    ///     new LocationsListRequest
    ///     {
    ///         CreatedAfter = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         CreatedBefore = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         Cursor = "cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw",
    ///         IncludeDeletedData = true,
    ///         IncludeRemoteData = true,
    ///         IncludeShellData = true,
    ///         LocationType = LocationsListRequestLocationType.Home,
    ///         ModifiedAfter = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         ModifiedBefore = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         PageSize = 1,
    ///         RemoteFields = LocationsListRequestRemoteFields.Country,
    ///         RemoteId = "remote_id",
    ///         ShowEnumOrigins = LocationsListRequestShowEnumOrigins.Country,
    ///     }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<Pager<Location>> ListAsync(
        LocationsListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (request is not null)
        {
            request = request with { };
        }
        var pager = await CursorPager<
            LocationsListRequest,
            RequestOptions?,
            PaginatedLocationList,
            string?,
            Location
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
    /// Returns a `Location` object with the given `id`.
    /// </summary>
    /// <example><code>
    /// await client.Hris.Locations.RetrieveAsync(
    ///     "id",
    ///     new LocationsRetrieveRequest
    ///     {
    ///         IncludeRemoteData = true,
    ///         IncludeShellData = true,
    ///         RemoteFields = LocationsRetrieveRequestRemoteFields.Country,
    ///         ShowEnumOrigins = LocationsRetrieveRequestShowEnumOrigins.Country,
    ///     }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<Location> RetrieveAsync(
        string id,
        LocationsRetrieveRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
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
            _query["remote_fields"] = request.RemoteFields.Value.Stringify();
        }
        if (request.ShowEnumOrigins != null)
        {
            _query["show_enum_origins"] = request.ShowEnumOrigins.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "hris/v1/locations/{0}",
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
                return JsonUtils.Deserialize<Location>(responseBody)!;
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
