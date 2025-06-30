using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Crm;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer;

[TestFixture]
public class CustomObjectClassesCustomObjectsCreateTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "model": {
                "fields": {
                  "test_field": "hello"
                }
              }
            }
            """;

        const string mockResponse = """
            {
              "model": {
                "id": "da0b1963-be70-469c-9f8c-06a81d0fe759",
                "remote_id": "4183634295",
                "created_at": "2021-09-15T00:00:00.000Z",
                "modified_at": "2021-10-16T00:00:00.000Z",
                "object_class": "ff1ff4cb-a66b-47dc-8e2a-50388049e602",
                "fields": {
                  "order_id": "4183634295",
                  "order_quantity": 50,
                  "customer_type": "Returning"
                },
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
                    .WithPath("/crm/v1/custom-object-classes/custom_object_class_id/custom-objects")
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

        var response = await Client.Crm.CustomObjects.CustomObjectClassesCustomObjectsCreateAsync(
            "custom_object_class_id",
            new CrmCustomObjectEndpointRequest
            {
                Model = new CustomObjectRequest
                {
                    Fields = new Dictionary<string, object>() { { "test_field", "hello" } },
                },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<CrmCustomObjectResponse>(mockResponse)).UsingDefaults()
        );
    }
}
