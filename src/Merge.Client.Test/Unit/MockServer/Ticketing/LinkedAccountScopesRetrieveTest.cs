using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using Merge.Client.Ticketing;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ticketing;

[TestFixture]
public class LinkedAccountScopesRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
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
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ticketing.Scopes.LinkedAccountScopesRetrieveAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<CommonModelScopeApi>(mockResponse)).UsingDefaults()
        );
    }
}
