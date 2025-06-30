using global::System.Threading.Tasks;
using Merge.Client.Crm;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer;

[TestFixture]
public class CustomObjectClassesCustomObjectsAssociationsListTest : BaseMockServerTest
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
                  "created_at": "2021-09-15T00:00:00.000Z",
                  "modified_at": "2021-10-16T00:00:00.000Z",
                  "source_object": "a8f5d29f-4e50-473f-8f12-27128ffcd37a",
                  "target_object": "da0b1963-be70-469c-9f8c-06a81d0fe759",
                  "association_type": "association_type"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/crm/v1/custom-object-classes/custom_object_class_id/custom-objects/object_id/associations"
                    )
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var pager =
            await Client.Crm.Associations.CustomObjectClassesCustomObjectsAssociationsListAsync(
                "custom_object_class_id",
                "object_id",
                new CustomObjectClassesCustomObjectsAssociationsListRequest()
            );
        await foreach (var item in pager)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
