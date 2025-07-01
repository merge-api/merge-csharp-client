using global::System.Threading.Tasks;
using Merge.Client.Crm;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer;

[TestFixture]
public class CustomObjectClassesCustomObjectsListTest : BaseMockServerTest
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
                  "id": "da0b1963-be70-469c-9f8c-06a81d0fe759",
                  "remote_id": "4183634295",
                  "created_at": "2021-09-15T00:00:00.000Z",
                  "modified_at": "2021-10-16T00:00:00.000Z",
                  "object_class": "ff1ff4cb-a66b-47dc-8e2a-50388049e602",
                  "fields": {
                    "order_id": "4183634295",
                    "order_quantity": 50,
                    "customer_type": "Returning"
                  },
                  "remote_fields": [
                    {
                      "remote_field_class": "remote_field_class"
                    }
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/crm/v1/custom-object-classes/custom_object_class_id/custom-objects")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var pager = await Client.Crm.CustomObjects.CustomObjectClassesCustomObjectsListAsync(
            "custom_object_class_id",
            new CustomObjectClassesCustomObjectsListRequest()
        );
        await foreach (var item in pager)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
