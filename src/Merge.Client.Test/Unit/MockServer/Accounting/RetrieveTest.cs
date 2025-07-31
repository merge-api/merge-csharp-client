using global::System.Threading.Tasks;
using Merge.Client.Accounting;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Accounting;

[TestFixture]
public class RetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "id": "ecbe05ac-62a3-46c5-ab31-4b478b37d1b4",
              "remote_id": "088899",
              "created_at": "2021-09-15T00:00:00.000Z",
              "modified_at": "2021-10-16T00:00:00.000Z",
              "number": "6",
              "transaction_date": "2020-03-31T00:00:00.000Z",
              "vendor": "vendor",
              "total_amount": 10000,
              "currency": "XUA",
              "exchange_rate": "2.9",
              "inclusive_of_tax": true,
              "company": "company",
              "lines": [
                {
                  "id": "ecbe05ac-62a3-46c5-ab31-4b478b37d1b4",
                  "remote_id": "121222",
                  "created_at": "2021-09-15T00:00:00.000Z",
                  "modified_at": "2021-10-16T00:00:00.000Z",
                  "net_amount": 25.54,
                  "tracking_category": "tracking_category",
                  "tracking_categories": [
                    "b38c59b0-a9d7-4740-b1ee-5436c6751e3d",
                    "9b840d2-686a-465a-8a8e-7b028498f8e4",
                    "a47e11b6-c73b-4a0c-be31-130fc48177fa"
                  ],
                  "description": "Gifted Merge Credit",
                  "account": "9d892439-5fab-4dbb-8bd8-34f7f96c7912",
                  "company": "595c8f97-2ac4-45b7-b000-41bdf43240b5",
                  "project": "22e65a5d-2df5-4e6e-884a-e538d0339000",
                  "contact": "908934-49j9-093f-0989-908923908",
                  "tax_rate": "a12e7c20-1922-9df7-s75n-edfeewnn7384",
                  "exchange_rate": "2.9",
                  "remote_was_deleted": false
                },
                {
                  "id": "ecbe05ac-62a3-46c5-ab31-4b478b37d1b4",
                  "remote_id": "121223",
                  "created_at": "2021-09-15T00:00:00.000Z",
                  "modified_at": "2021-10-16T00:00:00.000Z",
                  "net_amount": 10,
                  "tracking_category": "tracking_category",
                  "tracking_categories": [
                    "b38c59b0-a9d7-4740-b1ee-5436c6751e3d",
                    "9b840d2-686a-465a-8a8e-7b028498f8e4",
                    "a47e11b6-c73b-4a0c-be31-130fc48177fa"
                  ],
                  "description": "Refund for overpayment",
                  "account": "9d892439-5fab-4dbb-8bd8-34f7f96c7912",
                  "company": "595c8f97-2ac4-45b7-b000-41bdf43240b5",
                  "project": "project",
                  "contact": "contact",
                  "tax_rate": "a12e7c20-1922-9df7-s75n-edfeewnn7384",
                  "exchange_rate": "2.9",
                  "remote_was_deleted": true
                }
              ],
              "tracking_categories": [
                "b38c59b0-a9d7-4740-b1ee-5436c6751e3d",
                "9b840d2-686a-465a-8a8e-7b028498f8e4",
                "a47e11b6-c73b-4a0c-be31-130fc48177fa"
              ],
              "applied_to_lines": [
                {
                  "remote_id": "088899",
                  "created_at": "2021-09-15T00:00:00.000Z",
                  "modified_at": "2021-10-16T00:00:00.000Z",
                  "invoice": "5b3c1341-a20f-4e51-b72c-f3830a16c97b",
                  "applied_date": "2020-03-31T00:00:00.000Z",
                  "applied_amount": "2.9",
                  "remote_was_deleted": true
                }
              ],
              "remote_was_deleted": true,
              "accounting_period": "accounting_period",
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/accounting/v1/vendor-credits/id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Accounting.VendorCredits.RetrieveAsync(
            "id",
            new VendorCreditsRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<VendorCredit>(mockResponse)).UsingDefaults()
        );
    }
}
