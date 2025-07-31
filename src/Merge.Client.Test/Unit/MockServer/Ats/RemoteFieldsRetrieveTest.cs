using global::System.Threading.Tasks;
using Merge.Client.Ats;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ats;

[TestFixture]
public class RemoteFieldsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Activity": [
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
              "Application": [
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
              "Candidate": [
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
              "Department": [
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
              "EEOC": [
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
              "ScheduledInterview": [
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
              "Job": [
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
              "JobPosting": [
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
              "JobInterviewStage": [
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
              "Offer": [
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
              "Office": [
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
              "RejectReason": [
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
              "Scorecard": [
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
              "RemoteUser": [
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
                    .WithPath("/ats/v1/remote-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ats.FieldMapping.RemoteFieldsRetrieveAsync(
            new RemoteFieldsRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RemoteFieldApiResponse>(mockResponse)).UsingDefaults()
        );
    }
}
