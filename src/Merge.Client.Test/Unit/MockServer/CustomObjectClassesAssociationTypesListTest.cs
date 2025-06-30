using global::System.Threading.Tasks;
using Merge.Client.Crm;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer;

[TestFixture]
public class CustomObjectClassesAssociationTypesListTest : BaseMockServerTest
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
                  "id": "5bb73c32-3c6c-4757-ab7d-7d3540a1be31",
                  "remote_id": "93",
                  "created_at": "2021-09-15T00:00:00.000Z",
                  "modified_at": "2021-10-16T00:00:00.000Z",
                  "source_object_class": {
                    "id": "ff1ff4cb-a66b-47dc-8e2a-50388049e602",
                    "origin_type": "CUSTOM_OBJECT"
                  },
                  "target_object_classes": [
                    {
                      "id": "Opportunity",
                      "origin_type": "COMMON_MODEL"
                    }
                  ],
                  "remote_key_name": "order_to_opportunity",
                  "display_name": "Order to Opportunity",
                  "cardinality": "ONE_TO_ONE",
                  "is_required": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/crm/v1/custom-object-classes/custom_object_class_id/association-types"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var pager = await Client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesListAsync(
            "custom_object_class_id",
            new CustomObjectClassesAssociationTypesListRequest()
        );
        await foreach (var item in pager)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
