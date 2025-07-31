using global::System.Threading.Tasks;
using Merge.Client.Accounting;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Accounting;

[TestFixture]
public class PartialUpdateTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "model": {}
            }
            """;

        const string mockResponse = """
            {
              "model": {
                "id": "b26fd49a-cbae-470a-a8f8-bcbc119e0390",
                "remote_id": "987300",
                "created_at": "2021-09-15T00:00:00.000Z",
                "modified_at": "2021-10-16T00:00:00.000Z",
                "transaction_date": "2020-03-31T00:00:00.000Z",
                "contact": "contact",
                "account": "account",
                "payment_method": "payment_method",
                "currency": "XUA",
                "exchange_rate": "2.9",
                "company": "company",
                "total_amount": 50,
                "type": "ACCOUNTS_PAYABLE",
                "tracking_categories": [
                  "b38c59b0-a9d7-4740-b1ee-5436c6751e3d",
                  "9b840d2-686a-465a-8a8e-7b028498f8e4",
                  "a47e11b6-c73b-4a0c-be31-130fc48177fa"
                ],
                "accounting_period": "accounting_period",
                "applied_to_lines": [
                  {
                    "id": "ecbe05ac-62a3-46c5-ab31-4b478b37d1b4",
                    "remote_id": "234",
                    "created_at": "2021-09-15T00:00:00.000Z",
                    "modified_at": "2021-10-16T00:00:00.000Z",
                    "applied_amount": "25",
                    "applied_date": "2020-03-31T00:00:00.000Z",
                    "related_object_id": "a47e11b6-c73b-4a0c-be31-130fc48177fa",
                    "related_object_type": "INVOICE"
                  },
                  {
                    "id": "ecbe05ac-62a3-46c5-ab31-4b478b37d1b4",
                    "remote_id": "235",
                    "created_at": "2021-09-15T00:00:00.000Z",
                    "modified_at": "2021-10-16T00:00:00.000Z",
                    "applied_amount": "25",
                    "applied_date": "2020-03-31T00:00:00.000Z",
                    "related_object_id": "9b96a886-29a5-452b-8733-2a1e03497cf4",
                    "related_object_type": "CREDIT_NOTE"
                  }
                ],
                "remote_updated_at": "2020-03-31T00:00:00.000Z",
                "remote_was_deleted": true,
                "field_mappings": {
                  "organization_defined_targets": {
                    "custom_key": "custom_value"
                  },
                  "linked_account_defined_targets": {
                    "custom_key": "custom_value"
                  }
                },
                "remote_data": [
                  {
                    "path": "/actions",
                    "data": [
                      "Varies by platform"
                    ]
                  }
                ],
                "remote_fields": [
                  {
                    "remote_field_class": "remote_field_class"
                  }
                ]
              },
              "warnings": [
                {
                  "source": {
                    "pointer": "pointer"
                  },
                  "title": "Unrecognized Field",
                  "detail": "An unrecognized field, age, was passed in with request data.",
                  "problem_type": "UNRECOGNIZED_FIELD"
                }
              ],
              "errors": [
                {
                  "source": {
                    "pointer": "pointer"
                  },
                  "title": "Missing Required Field",
                  "detail": "custom_fields is a required field on model.",
                  "problem_type": "MISSING_REQUIRED_FIELD"
                }
              ],
              "logs": [
                {
                  "log_id": "99433219-8017-4acd-bb3c-ceb23d663832",
                  "dashboard_view": "https://app.merge.dev/logs/99433219-8017-4acd-bb3c-ceb23d663832",
                  "log_summary": {
                    "url": "www.exampleintegration.com/api/v1/exampleapi",
                    "method": "POST",
                    "status_code": 200
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/accounting/v1/payments/id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Accounting.Payments.PartialUpdateAsync(
            "id",
            new PatchedPaymentEndpointRequest { Model = new PatchedPaymentRequest() }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<PaymentResponse>(mockResponse)).UsingDefaults()
        );
    }
}
