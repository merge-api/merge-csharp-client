using System.Text.Json;
using Merge.Client;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class FilesClient
{
    private RawClient _client;

    public FilesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns a list of `File` objects.
    /// </summary>
    public async Task<PaginatedFileList> ListAsync(FilesListRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.CreatedAfter != null)
        {
            _query["created_after"] = request.CreatedAfter.Value.ToString("o0");
        }
        if (request.CreatedBefore != null)
        {
            _query["created_before"] = request.CreatedBefore.Value.ToString("o0");
        }
        if (request.Cursor != null)
        {
            _query["cursor"] = request.Cursor;
        }
        if (request.DriveId != null)
        {
            _query["drive_id"] = request.DriveId;
        }
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand.ToString();
        }
        if (request.FolderId != null)
        {
            _query["folder_id"] = request.FolderId;
        }
        if (request.IncludeDeletedData != null)
        {
            _query["include_deleted_data"] = request.IncludeDeletedData.ToString();
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        if (request.MimeType != null)
        {
            _query["mime_type"] = request.MimeType;
        }
        if (request.ModifiedAfter != null)
        {
            _query["modified_after"] = request.ModifiedAfter.Value.ToString("o0");
        }
        if (request.ModifiedBefore != null)
        {
            _query["modified_before"] = request.ModifiedBefore.Value.ToString("o0");
        }
        if (request.Name != null)
        {
            _query["name"] = request.Name;
        }
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.ToString();
        }
        if (request.RemoteId != null)
        {
            _query["remote_id"] = request.RemoteId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/filestorage/v1/files",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<PaginatedFileList>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a `File` object with the given values.
    /// </summary>
    public async Task<FileStorageFileResponse> CreateAsync(FileStorageFileEndpointRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.IsDebugMode != null)
        {
            _query["is_debug_mode"] = request.IsDebugMode.ToString();
        }
        if (request.RunAsync != null)
        {
            _query["run_async"] = request.RunAsync.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/filestorage/v1/files",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FileStorageFileResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a `File` object with the given `id`.
    /// </summary>
    public async Task<File> RetrieveAsync(string id, FilesRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Expand != null)
        {
            _query["expand"] = request.Expand.ToString();
        }
        if (request.IncludeRemoteData != null)
        {
            _query["include_remote_data"] = request.IncludeRemoteData.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/filestorage/v1/files/{id}",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<File>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns a `File` object with the given `id`.
    /// </summary>
    public async void DownloadRetrieveAsync(string id, FilesDownloadRetrieveRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.MimeType != null)
        {
            _query["mime_type"] = request.MimeType;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/filestorage/v1/files/{id}/download",
                Query = _query
            }
        );
    }

    /// <summary>
    /// Returns metadata for `FileStorageFile` POSTs.
    /// </summary>
    public async Task<MetaResponse> MetaPostRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.ApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/filestorage/v1/files/meta/post"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<MetaResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
