using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Ticketing;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer;

[TestFixture]
public class LinkedAccountScopesCreateTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "common_models": [
                {
                  "model_name": "Employee",
                  "model_permissions": {
                    "READ": {
                      "is_enabled": true
                    },
                    "WRITE": {
                      "is_enabled": false
                    }
                  },
                  "field_permissions": {
                    "enabled_fields": [
                      "avatar",
                      "home_location"
                    ],
                    "disabled_fields": [
                      "work_location"
                    ]
                  }
                },
                {
                  "model_name": "Benefit",
                  "model_permissions": {
                    "WRITE": {
                      "is_enabled": false
                    }
                  }
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "common_models": [
                {
                  "model_name": "Employee",
                  "model_permissions": {
                    "READ": {
                      "is_enabled": true
                    },
                    "WRITE": {
                      "is_enabled": false
                    }
                  },
                  "field_permissions": {
                    "enabled_fields": [
                      "avatar",
                      "created_at",
                      "custom_fields",
                      "date_of_birth",
                      "first_name",
                      "gender",
                      "remote_created_at",
                      "remote_data"
                    ],
                    "disabled_fields": [
                      "company",
                      "employments",
                      "groups",
                      "home_location",
                      "manager",
                      "work_location"
                    ]
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ticketing/v1/linked-account-scopes")
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

        var response = await Client.Ticketing.Scopes.LinkedAccountScopesCreateAsync(
            new LinkedAccountCommonModelScopeDeserializerRequest
            {
                CommonModels = new List<Ticketing.IndividualCommonModelScopeDeserializerRequest>()
                {
                    new Ticketing.IndividualCommonModelScopeDeserializerRequest
                    {
                        ModelName = "Employee",
                        ModelPermissions = new Dictionary<
                            string,
                            Ticketing.ModelPermissionDeserializerRequest
                        >()
                        {
                            {
                                "READ",
                                new Ticketing.ModelPermissionDeserializerRequest
                                {
                                    IsEnabled = true,
                                }
                            },
                            {
                                "WRITE",
                                new Ticketing.ModelPermissionDeserializerRequest
                                {
                                    IsEnabled = false,
                                }
                            },
                        },
                        FieldPermissions = new Ticketing.FieldPermissionDeserializerRequest
                        {
                            EnabledFields = new List<object>() { "avatar", "home_location" },
                            DisabledFields = new List<object>() { "work_location" },
                        },
                    },
                    new Ticketing.IndividualCommonModelScopeDeserializerRequest
                    {
                        ModelName = "Benefit",
                        ModelPermissions = new Dictionary<
                            string,
                            Ticketing.ModelPermissionDeserializerRequest
                        >()
                        {
                            {
                                "WRITE",
                                new Ticketing.ModelPermissionDeserializerRequest
                                {
                                    IsEnabled = false,
                                }
                            },
                        },
                    },
                },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<Ticketing.CommonModelScopeApi>(mockResponse))
                .UsingDefaults()
        );
    }
}
