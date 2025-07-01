using global::System.Threading.Tasks;
using Merge.Client.Ticketing;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer;

[TestFixture]
public class UsersListTest : BaseMockServerTest
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
                      "path": "/platform-endpoint"
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
                    .WithPath("/ticketing/v1/projects/parent_id/users")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var pager = await Client.Ticketing.Projects.UsersListAsync(
            "parent_id",
            new ProjectsUsersListRequest()
        );
        await foreach (var item in pager)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
