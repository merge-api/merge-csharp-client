using global::System.Threading.Tasks;
using Merge.Client.Ats;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ats;

[TestFixture]
public class ChangeStageCreateTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "model": {
                "id": "92e8a369-fffe-430d-b93a-f7e8a16563f1",
                "remote_id": "98796",
                "created_at": "2021-09-15T00:00:00.000Z",
                "modified_at": "2021-10-16T00:00:00.000Z",
                "candidate": "candidate",
                "job": "job",
                "applied_at": "2021-10-15T00:00:00.000Z",
                "rejected_at": "2021-11-15T00:00:00.000Z",
                "offers": [
                  "e9b5c11d-c588-468e-8567-cd6992e42b62"
                ],
                "source": "Campus recruiting event",
                "credited_to": "credited_to",
                "screening_question_answers": [
                  "screening_question_answers",
                  "screening_question_answers"
                ],
                "current_stage": "current_stage",
                "reject_reason": "reject_reason",
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
                    "path": "/candidacies",
                    "data": [
                      "Varies by platform"
                    ]
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
                    .WithPath("/ats/v1/applications/id/change-stage")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ats.Applications.ChangeStageCreateAsync(
            "id",
            new UpdateApplicationStageRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ApplicationResponse>(mockResponse)).UsingDefaults()
        );
    }
}
