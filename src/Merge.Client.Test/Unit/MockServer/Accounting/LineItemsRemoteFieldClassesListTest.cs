using global::System.Threading.Tasks;
using Merge.Client.Accounting;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Accounting;

[TestFixture]
public class LineItemsRemoteFieldClassesListTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "next": "cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw",
              "previous": "cj1sZXdwd2VycWVtY29zZnNkc2NzUWxNMEUxTXk0ME16UXpNallsTWtJ",
              "results": [
                {
                  "id": "id",
                  "display_name": "display_name",
                  "remote_key_name": "remote_key_name",
                  "description": "description",
                  "is_custom": true,
                  "is_required": true,
                  "field_type": "string",
                  "field_format": "string",
                  "field_choices": [
                    "field_choices"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/accounting/v1/purchase-orders/line-items/remote-field-classes")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var pager = await Client.Accounting.PurchaseOrders.LineItemsRemoteFieldClassesListAsync(
            new PurchaseOrdersLineItemsRemoteFieldClassesListRequest()
        );
        await foreach (var item in pager)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
