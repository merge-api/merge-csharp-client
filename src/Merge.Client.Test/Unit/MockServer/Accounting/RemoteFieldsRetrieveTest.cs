using global::System.Threading.Tasks;
using Merge.Client.Accounting;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Accounting;

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
              "AccountingAttachment": [
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
              "BalanceSheet": [
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
              "CashFlowStatement": [
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
              "CompanyInfo": [
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
              "IncomeStatement": [
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
              "CreditNote": [
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
              "Item": [
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
              "PurchaseOrder": [
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
              "TrackingCategory": [
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
              "JournalEntry": [
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
              "TaxRate": [
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
              "Invoice": [
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
              "Payment": [
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
              "Expense": [
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
              "VendorCredit": [
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
              "Transaction": [
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
              "AccountingPeriod": [
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
              "GeneralLedgerTransaction": [
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
              "BankFeedAccount": [
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
              "PaymentMethod": [
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
              "PaymentTerm": [
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
                    .WithPath("/accounting/v1/remote-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Accounting.FieldMapping.RemoteFieldsRetrieveAsync(
            new RemoteFieldsRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RemoteFieldApiResponse>(mockResponse)).UsingDefaults()
        );
    }
}
