using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Crm;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Crm;

[TestFixture]
public class FieldMappingsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Account": [
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
              "Contact": [
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
              "Lead": [
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
              "Note": [
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
              "Opportunity": [
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
              "Stage": [
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
              ],
              "Task": [
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
              "Engagement": [
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
                    .WithPath("/crm/v1/field-mappings")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Crm.FieldMapping.FieldMappingsRetrieveAsync(
            new FieldMappingsRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<FieldMappingApiInstanceResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
