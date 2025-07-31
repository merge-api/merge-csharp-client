using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using Merge.Client.Ticketing;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ticketing;

[TestFixture]
public class PartialUpdateTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "model": {}
            }
            """;

        const string mockResponse = """
            {
              "model": {
                "id": "0958cbc6-6040-430a-848e-aafacbadf4ae",
                "remote_id": "19202938",
                "created_at": "2021-09-15T00:00:00.000Z",
                "modified_at": "2021-10-16T00:00:00.000Z",
                "name": "Please add more integrations",
                "assignees": [
                  "17a54124-287f-494d-965e-3c5b330c9a68"
                ],
                "assigned_teams": [
                  "4857c306-c1f9-489e-a6b6-90902f736dfe"
                ],
                "creator": "creator",
                "due_date": "2022-10-11T00:00:00.000Z",
                "status": "OPEN",
                "description": "Can you please add more integrations? It'll make syncing data much easier!",
                "collections": [
                  "fb8c55b6-1cb8-4b4c-9fb6-17924231619d"
                ],
                "ticket_type": "incident",
                "account": "account",
                "contact": "contact",
                "parent_ticket": "parent_ticket",
                "attachments": [
                  "42747df1-95e7-46e2-93cc-66f1191edca5",
                  "92f972d0-2526-434b-9409-4c3b468e08f0"
                ],
                "access_level": "COMPANY",
                "tags": [
                  "enterprise",
                  "other-tag"
                ],
                "roles": [
                  "21a54124-397f-494d-985e-3c5b330b8a68",
                  "17a54124-287f-494d-965e-3c5b330c9a68"
                ],
                "ticket_url": "https://thirdpartysoftware.com/project/3/issue/1",
                "priority": "URGENT",
                "remote_created_at": "2021-11-10T00:00:00.000Z",
                "remote_updated_at": "2021-12-09T00:00:00.000Z",
                "completed_at": "2021-12-09T00:00:00.000Z",
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
                ],
                "remote_fields": [
                  {
                    "remote_field_class": "remote_field_class"
                  }
                ]
              },
              "warnings": [
                {
                  "source": {
                    "pointer": "pointer"
                  },
                  "title": "Unrecognized Field",
                  "detail": "An unrecognized field, age, was passed in with request data.",
                  "problem_type": "UNRECOGNIZED_FIELD"
                }
              ],
              "errors": [
                {
                  "source": {
                    "pointer": "pointer"
                  },
                  "title": "Missing Required Field",
                  "detail": "custom_fields is a required field on model.",
                  "problem_type": "MISSING_REQUIRED_FIELD"
                }
              ],
              "logs": [
                {
                  "log_id": "99433219-8017-4acd-bb3c-ceb23d663832",
                  "dashboard_view": "https://app.merge.dev/logs/99433219-8017-4acd-bb3c-ceb23d663832",
                  "log_summary": {
                    "url": "www.exampleintegration.com/api/v1/exampleapi",
                    "method": "POST",
                    "status_code": 200
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ticketing/v1/tickets/id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ticketing.Tickets.PartialUpdateAsync(
            "id",
            new PatchedTicketEndpointRequest { Model = new PatchedTicketRequest() }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<TicketResponse>(mockResponse)).UsingDefaults()
        );
    }
}
