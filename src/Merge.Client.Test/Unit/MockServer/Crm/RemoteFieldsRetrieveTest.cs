using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Crm;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Crm;

[TestFixture]
public class RemoteFieldsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Account": [
                {
                  "schema": {
                    "type": "string"
                  },
                  "remote_key_name": "example_remote_key_name",
                  "remote_endpoint_info": {
                    "method": "GET",
                    "url_path": "/example-url-path",
                    "field_traversal_path": [
                      "example_key_name"
                    ]
                  },
                  "example_values": [
                    "example"
                  ],
                  "advanced_metadata": {
                    "id": "id"
                  },
                  "coverage": 1
                }
              ],
              "Contact": [
                {
                  "schema": {
                    "type": "string"
                  },
                  "remote_key_name": "example_remote_key_name",
                  "remote_endpoint_info": {
                    "method": "GET",
                    "url_path": "/example-url-path",
                    "field_traversal_path": [
                      "example_key_name"
                    ]
                  },
                  "example_values": [
                    "example"
                  ],
                  "advanced_metadata": {
                    "id": "id"
                  },
                  "coverage": 1
                }
              ],
              "Lead": [
                {
                  "schema": {
                    "type": "string"
                  },
                  "remote_key_name": "example_remote_key_name",
                  "remote_endpoint_info": {
                    "method": "GET",
                    "url_path": "/example-url-path",
                    "field_traversal_path": [
                      "example_key_name"
                    ]
                  },
                  "example_values": [
                    "example"
                  ],
                  "advanced_metadata": {
                    "id": "id"
                  },
                  "coverage": 1
                }
              ],
              "Note": [
                {
                  "schema": {
                    "type": "string"
                  },
                  "remote_key_name": "example_remote_key_name",
                  "remote_endpoint_info": {
                    "method": "GET",
                    "url_path": "/example-url-path",
                    "field_traversal_path": [
                      "example_key_name"
                    ]
                  },
                  "example_values": [
                    "example"
                  ],
                  "advanced_metadata": {
                    "id": "id"
                  },
                  "coverage": 1
                }
              ],
              "Opportunity": [
                {
                  "schema": {
                    "type": "string"
                  },
                  "remote_key_name": "example_remote_key_name",
                  "remote_endpoint_info": {
                    "method": "GET",
                    "url_path": "/example-url-path",
                    "field_traversal_path": [
                      "example_key_name"
                    ]
                  },
                  "example_values": [
                    "example"
                  ],
                  "advanced_metadata": {
                    "id": "id"
                  },
                  "coverage": 1
                }
              ],
              "Stage": [
                {
                  "schema": {
                    "type": "string"
                  },
                  "remote_key_name": "example_remote_key_name",
                  "remote_endpoint_info": {
                    "method": "GET",
                    "url_path": "/example-url-path",
                    "field_traversal_path": [
                      "example_key_name"
                    ]
                  },
                  "example_values": [
                    "example"
                  ],
                  "advanced_metadata": {
                    "id": "id"
                  },
                  "coverage": 1
                }
              ],
              "User": [
                {
                  "schema": {
                    "type": "string"
                  },
                  "remote_key_name": "example_remote_key_name",
                  "remote_endpoint_info": {
                    "method": "GET",
                    "url_path": "/example-url-path",
                    "field_traversal_path": [
                      "example_key_name"
                    ]
                  },
                  "example_values": [
                    "example"
                  ],
                  "advanced_metadata": {
                    "id": "id"
                  },
                  "coverage": 1
                }
              ],
              "Task": [
                {
                  "schema": {
                    "type": "string"
                  },
                  "remote_key_name": "example_remote_key_name",
                  "remote_endpoint_info": {
                    "method": "GET",
                    "url_path": "/example-url-path",
                    "field_traversal_path": [
                      "example_key_name"
                    ]
                  },
                  "example_values": [
                    "example"
                  ],
                  "advanced_metadata": {
                    "id": "id"
                  },
                  "coverage": 1
                }
              ],
              "Engagement": [
                {
                  "schema": {
                    "type": "string"
                  },
                  "remote_key_name": "example_remote_key_name",
                  "remote_endpoint_info": {
                    "method": "GET",
                    "url_path": "/example-url-path",
                    "field_traversal_path": [
                      "example_key_name"
                    ]
                  },
                  "example_values": [
                    "example"
                  ],
                  "advanced_metadata": {
                    "id": "id"
                  },
                  "coverage": 1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/crm/v1/remote-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Crm.FieldMapping.RemoteFieldsRetrieveAsync(
            new RemoteFieldsRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RemoteFieldApiResponse>(mockResponse)).UsingDefaults()
        );
    }
}
