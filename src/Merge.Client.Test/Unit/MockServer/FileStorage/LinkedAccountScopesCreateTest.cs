using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.FileStorage;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.FileStorage;

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
                    .WithPath("/filestorage/v1/linked-account-scopes")
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

        var response = await Client.FileStorage.Scopes.LinkedAccountScopesCreateAsync(
            new LinkedAccountCommonModelScopeDeserializerRequest
            {
                CommonModels = new List<IndividualCommonModelScopeDeserializerRequest>()
                {
                    new IndividualCommonModelScopeDeserializerRequest
                    {
                        ModelName = "Employee",
                        ModelPermissions = new Dictionary<
                            string,
                            ModelPermissionDeserializerRequest
                        >()
                        {
                            {
                                "READ",
                                new ModelPermissionDeserializerRequest { IsEnabled = true }
                            },
                            {
                                "WRITE",
                                new ModelPermissionDeserializerRequest { IsEnabled = false }
                            },
                        },
                        FieldPermissions = new FieldPermissionDeserializerRequest
                        {
                            EnabledFields = new List<object>() { "avatar", "home_location" },
                            DisabledFields = new List<object>() { "work_location" },
                        },
                    },
                    new IndividualCommonModelScopeDeserializerRequest
                    {
                        ModelName = "Benefit",
                        ModelPermissions = new Dictionary<
                            string,
                            ModelPermissionDeserializerRequest
                        >()
                        {
                            {
                                "WRITE",
                                new ModelPermissionDeserializerRequest { IsEnabled = false }
                            },
                        },
                    },
                },
            }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<CommonModelScopeApi>(mockResponse)).UsingDefaults()
        );
    }
}
