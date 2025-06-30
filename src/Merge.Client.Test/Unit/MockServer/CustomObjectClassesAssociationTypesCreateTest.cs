using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Crm;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer;

[TestFixture]
public class CustomObjectClassesAssociationTypesCreateTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "model": {
                "source_object_class": {
                  "id": "id",
                  "origin_type": "CUSTOM_OBJECT"
                },
                "target_object_classes": [
                  {
                    "id": "id",
                    "origin_type": "CUSTOM_OBJECT"
                  }
                ],
                "remote_key_name": "remote_key_name"
              }
            }
            """;

        const string mockResponse = """
            {
              "model": {
                "id": "5bb73c32-3c6c-4757-ab7d-7d3540a1be31",
                "remote_id": "93",
                "created_at": "2021-09-15T00:00:00.000Z",
                "modified_at": "2021-10-16T00:00:00.000Z",
                "source_object_class": {
                  "id": "ff1ff4cb-a66b-47dc-8e2a-50388049e602",
                  "origin_type": "CUSTOM_OBJECT"
                },
                "target_object_classes": [
                  {
                    "id": "Opportunity",
                    "origin_type": "COMMON_MODEL"
                  }
                ],
                "remote_key_name": "order_to_opportunity",
                "display_name": "Order to Opportunity",
                "cardinality": "ONE_TO_ONE",
                "is_required": true
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
                    .WithPath(
                        "/crm/v1/custom-object-classes/custom_object_class_id/association-types"
                    )
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

        var response =
            await Client.Crm.AssociationTypes.CustomObjectClassesAssociationTypesCreateAsync(
                "custom_object_class_id",
                new CrmAssociationTypeEndpointRequest
                {
                    Model = new AssociationTypeRequestRequest
                    {
                        SourceObjectClass = new ObjectClassDescriptionRequest
                        {
                            Id = "id",
                            OriginType = OriginTypeEnum.CustomObject,
                        },
                        TargetObjectClasses = new List<ObjectClassDescriptionRequest>()
                        {
                            new ObjectClassDescriptionRequest
                            {
                                Id = "id",
                                OriginType = OriginTypeEnum.CustomObject,
                            },
                        },
                        RemoteKeyName = "remote_key_name",
                    },
                }
            );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<CrmAssociationTypeResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
