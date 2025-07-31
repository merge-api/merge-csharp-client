using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Hris;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Hris;

[TestFixture]
public class RemoteFieldsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Benefit": [
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
              "EmployerBenefit": [
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
              "Company": [
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
              "EmployeePayrollRun": [
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
              "Employee": [
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
              "Employment": [
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
              "Location": [
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
              "PayrollRun": [
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
              "TimeOff": [
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
              "TimeOffBalance": [
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
              "BankInfo": [
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
              "PayGroup": [
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
              "Group": [
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
              "Dependent": [
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
              "TimesheetEntry": [
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
                    .WithPath("/hris/v1/remote-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Hris.FieldMapping.RemoteFieldsRetrieveAsync(
            new RemoteFieldsRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RemoteFieldApiResponse>(mockResponse)).UsingDefaults()
        );
    }
}
