using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Ticketing;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer;

[TestFixture]
public class RetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "id": "17a54124-287f-494d-965e-3c5b330c9a68",
              "remote_id": "19202938",
              "created_at": "2021-09-15T00:00:00.000Z",
              "modified_at": "2021-10-16T00:00:00.000Z",
              "name": "Gil Feig",
              "email_address": "help@merge.dev",
              "is_active": true,
              "teams": [
                "28b54125-287f-494d-965e-3c5b330c9a68",
                "17a54124-287f-494d-965e-3c5b330c9a68"
              ],
              "roles": [
                "23454124-387f-494d-265e-345b330c9123"
              ],
              "avatar": "https://merge.dev/user_profile_pic.png",
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
                  "path": "/platform-endpoint",
                  "data": {
                    "key": "value"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ticketing/v1/users/id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ticketing.Users.RetrieveAsync("id", new UsersRetrieveRequest());
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<Ticketing.User>(mockResponse)).UsingDefaults()
        );
    }
}
