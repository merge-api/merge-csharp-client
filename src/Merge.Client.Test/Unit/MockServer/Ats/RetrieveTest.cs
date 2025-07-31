using global::System.Threading.Tasks;
using Merge.Client.Ats;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ats;

[TestFixture]
public class RetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "id": "b82302de-852e-4e60-b050-edf9da3b7c02",
              "remote_id": "344321",
              "created_at": "2021-09-15T00:00:00.000Z",
              "modified_at": "2021-10-16T00:00:00.000Z",
              "first_name": "Shensi",
              "last_name": "Ding",
              "email": "hello@merge.dev",
              "disabled": true,
              "remote_created_at": "2020-11-10T00:00:00.000Z",
              "access_role": "SUPER_ADMIN",
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
              ]
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/ats/v1/users/id").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ats.Users.RetrieveAsync("id", new UsersRetrieveRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<RemoteUser>(mockResponse)).UsingDefaults()
        );
    }
}
