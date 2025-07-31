using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Crm;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Crm;

[TestFixture]
public class FieldMappingsPartialUpdateTest : BaseMockServerTest
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
                "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                "is_integration_wide": true,
                "target_field": {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_organization_wide": true
                },
                "remote_field": {
                  "remote_key_name": "example_remote_field_key",
                  "schema": {
                    "type": "string"
                  },
                  "remote_endpoint_info": {
                    "method": "GET",
                    "url_path": "/example-url-path",
                    "field_traversal_path": [
                      "example_remote_field_key"
                    ]
                  }
                }
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
                    .WithPath("/crm/v1/field-mappings/field_mapping_id")
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

        var response = await Client.Crm.FieldMapping.FieldMappingsPartialUpdateAsync(
            "field_mapping_id",
            new PatchedEditFieldMappingRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<FieldMappingInstanceResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
