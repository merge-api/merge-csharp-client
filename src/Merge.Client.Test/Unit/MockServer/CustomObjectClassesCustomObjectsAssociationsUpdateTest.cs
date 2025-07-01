using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Crm;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer;

[TestFixture]
public class CustomObjectClassesCustomObjectsAssociationsUpdateTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "created_at": "2021-09-15T00:00:00.000Z",
              "modified_at": "2021-10-16T00:00:00.000Z",
              "source_object": "a8f5d29f-4e50-473f-8f12-27128ffcd37a",
              "target_object": "da0b1963-be70-469c-9f8c-06a81d0fe759",
              "association_type": "association_type"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/crm/v1/custom-object-classes/source_class_id/custom-objects/source_object_id/associations/target_class_id/target_object_id/association_type_id"
                    )
                    .UsingPut()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response =
            await Client.Crm.Associations.CustomObjectClassesCustomObjectsAssociationsUpdateAsync(
                "association_type_id",
                "source_class_id",
                "source_object_id",
                "target_class_id",
                "target_object_id",
                new CustomObjectClassesCustomObjectsAssociationsUpdateRequest()
            );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<Association>(mockResponse)).UsingDefaults()
        );
    }
}
