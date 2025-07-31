using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Crm;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Crm;

[TestFixture]
public class RetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "id": "0358cbc6-2040-430a-848e-aafacbadf3aa",
              "remote_id": "19202938",
              "created_at": "2021-09-15T00:00:00.000Z",
              "modified_at": "2021-10-16T00:00:00.000Z",
              "name": "Gil Feig",
              "email": "merge_is_hiring@merge.dev",
              "is_active": true,
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
                  "path": "/users",
                  "data": [
                    "Varies by platform"
                  ]
                }
              ],
              "remote_fields": [
                {
                  "remote_field_class": "remote_field_class",
                  "value": {
                    "key": "value"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/crm/v1/users/id").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Crm.Users.RetrieveAsync("id", new UsersRetrieveRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<User>(mockResponse)).UsingDefaults()
        );
    }
}
