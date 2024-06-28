using System.Text.Json;
using Merge.Client;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

public class FieldMappingClient
{
    private RawClient _client;

    public FieldMappingClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Get all Field Mappings for this Linked Account. Field Mappings are mappings between third-party Remote Fields and user defined Merge fields. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/overview/).
    /// </summary>
    public async Task<FieldMappingApiInstanceResponse> FieldMappingsRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = "crm/v1/field-mappings" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FieldMappingApiInstanceResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create new Field Mappings that will be available after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
    /// </summary>
    public async Task<FieldMappingInstanceResponse> FieldMappingsCreateAsync(
        CreateFieldMappingRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "crm/v1/field-mappings",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FieldMappingInstanceResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes Field Mappings for a Linked Account. All data related to this Field Mapping will be deleted and these changes will be reflected after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
    /// </summary>
    public async Task<FieldMappingInstanceResponse> FieldMappingsDestroyAsync(string fieldMappingId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"crm/v1/field-mappings/{fieldMappingId}"
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FieldMappingInstanceResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create or update existing Field Mappings for a Linked Account. Changes will be reflected after the next scheduled sync. This will cause the next sync for this Linked Account to sync **ALL** data from start.
    /// </summary>
    public async Task<FieldMappingInstanceResponse> FieldMappingsPartialUpdateAsync(
        string fieldMappingId,
        PatchedEditFieldMappingRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Patch,
                Path = $"crm/v1/field-mappings/{fieldMappingId}",
                Body = request
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<FieldMappingInstanceResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get all remote fields for a Linked Account. Remote fields are third-party fields that are accessible after initial sync if remote_data is enabled. You can use remote fields to override existing Merge fields or map a new Merge field. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/overview/).
    /// </summary>
    public async Task<RemoteFieldApiResponse> RemoteFieldsRetrieveAsync(
        RemoteFieldsRetrieveRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.CommonModels != null)
        {
            _query["common_models"] = request.CommonModels;
        }
        if (request.IncludeExampleValues != null)
        {
            _query["include_example_values"] = request.IncludeExampleValues;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "crm/v1/remote-fields",
                Query = _query
            }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<RemoteFieldApiResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Get all organization-wide Target Fields, this will not include any Linked Account specific Target Fields. Organization-wide Target Fields are additional fields appended to the Merge Common Model for all Linked Accounts in a category. [Learn more](https://docs.merge.dev/supplemental-data/field-mappings/target-fields/).
    /// </summary>
    public async Task<ExternalTargetFieldApiResponse> TargetFieldsRetrieveAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = "crm/v1/target-fields" }
        );
        string responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode >= 200 && response.StatusCode < 400)
        {
            return JsonSerializer.Deserialize<ExternalTargetFieldApiResponse>(responseBody);
        }
        throw new Exception(responseBody);
    }
}
