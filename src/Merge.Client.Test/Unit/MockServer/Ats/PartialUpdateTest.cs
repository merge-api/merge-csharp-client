using global::System.Threading.Tasks;
using Merge.Client.Ats;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ats;

[TestFixture]
public class PartialUpdateTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "model": {},
              "remote_user_id": "remote_user_id"
            }
            """;

        const string mockResponse = """
            {
              "model": {
                "id": "521b18c2-4d01-4297-b451-19858d07c133",
                "remote_id": "21198",
                "created_at": "2021-09-15T00:00:00.000Z",
                "modified_at": "2021-10-16T00:00:00.000Z",
                "first_name": "Gil",
                "last_name": "Feig",
                "company": "Columbia Dining App.",
                "title": "Software Engineer",
                "remote_created_at": "2021-10-15T00:00:00.000Z",
                "remote_updated_at": "2021-10-16T00:00:00.000Z",
                "last_interaction_at": "2021-10-17T00:00:00.000Z",
                "is_private": true,
                "can_email": true,
                "locations": [
                  "San Francisco",
                  "New York",
                  "Miami"
                ],
                "phone_numbers": [
                  {
                    "created_at": "2021-09-15T00:00:00.000Z",
                    "modified_at": "2021-10-16T00:00:00.000Z",
                    "value": "+1234567890",
                    "phone_number_type": "MOBILE"
                  }
                ],
                "email_addresses": [
                  {
                    "created_at": "2021-09-15T00:00:00.000Z",
                    "modified_at": "2021-10-16T00:00:00.000Z",
                    "value": "hello@merge.dev",
                    "email_address_type": "PERSONAL"
                  }
                ],
                "urls": [
                  {
                    "created_at": "2021-09-15T00:00:00.000Z",
                    "modified_at": "2021-10-16T00:00:00.000Z",
                    "value": "http://alturl.com/p749b",
                    "url_type": "BLOG"
                  }
                ],
                "tags": [
                  "High-Priority"
                ],
                "applications": [
                  "29eb9867-ce2a-403f-b8ce-f2844b89f078",
                  "b4d08e5c-de00-4d64-a29f-66addac9af99",
                  "4ff877d2-fb3e-4a5b-a7a5-168ddf2ffa56"
                ],
                "attachments": [
                  "bea08964-32b4-4a20-8bb4-2612ba09de1d"
                ],
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
                    "path": "/candidates",
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
                    .WithPath("/ats/v1/candidates/id")
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

        var response = await Client.Ats.Candidates.PartialUpdateAsync(
            "id",
            new PatchedCandidateEndpointRequest
            {
                Model = new PatchedCandidateRequest(),
                RemoteUserId = "remote_user_id",
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<CandidateResponse>(mockResponse)).UsingDefaults()
        );
    }
}
