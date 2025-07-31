using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using Merge.Client.Ticketing;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ticketing;

[TestFixture]
public class RemoteFieldsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Ticket": [
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
              "Comment": [
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
              "Project": [
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
              "Collection": [
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
              "Role": [
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
              "Team": [
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
              "Attachment": [
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
              "Tag": [
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ticketing/v1/remote-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ticketing.FieldMapping.RemoteFieldsRetrieveAsync(
            new RemoteFieldsRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RemoteFieldApiResponse>(mockResponse)).UsingDefaults()
        );
    }
}
