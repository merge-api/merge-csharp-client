using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Crm;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Crm;

[TestFixture]
public class TargetFieldsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Account": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Contact": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Lead": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Note": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Opportunity": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Stage": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "User": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Task": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Engagement": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/crm/v1/target-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Crm.FieldMapping.TargetFieldsRetrieveAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ExternalTargetFieldApiResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
