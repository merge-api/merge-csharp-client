using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.FileStorage;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.FileStorage;

[TestFixture]
public class FieldMappingsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "File": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Folder": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Drive": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "Group": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ],
              "User": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "is_integration_wide": true,
                  "target_field": {
                    "name": "example_target_field_name",
                    "description": "this is a example description of a target field",
                    "is_organization_wide": true
                  },
                  "remote_field": {
                    "remote_key_name": "example_remote_field_key",
                    "schema": {
                      "type": "string"
                    },
                    "remote_endpoint_info": {
                      "method": "GET",
                      "url_path": "/example-url-path",
                      "field_traversal_path": [
                        "example_remote_field_key"
                      ]
                    }
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/filestorage/v1/field-mappings")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FileStorage.FieldMapping.FieldMappingsRetrieveAsync(
            new FieldMappingsRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<FieldMappingApiInstanceResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
