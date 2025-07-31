using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Crm;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Crm;

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
                "id": "550e8400-e29b-41d4-a716-446655440000",
                "remote_id": "19202938",
                "created_at": "2021-09-15T00:00:00.000Z",
                "modified_at": "2021-10-16T00:00:00.000Z",
                "subject": "Contact about Integration Strategy",
                "content": "Follow up to see whether they need integrations",
                "owner": "owner",
                "account": "account",
                "opportunity": "opportunity",
                "completed_date": "2022-02-11T00:00:00.000Z",
                "due_date": "2022-02-10T00:00:00.000Z",
                "status": "OPEN",
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
                    "path": "/tasks",
                    "data": [
                      "Varies by platform"
                    ]
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
                    .WithPath("/crm/v1/tasks/id")
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

        var response = await Client.Crm.Tasks.PartialUpdateAsync(
            "id",
            new PatchedTaskEndpointRequest { Model = new PatchedTaskRequest() }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<TaskResponse>(mockResponse)).UsingDefaults()
        );
    }
}
