using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using Merge.Client.Ticketing;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ticketing;

[TestFixture]
public class TargetFieldsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Ticket": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Comment": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Project": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Collection": [
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
              "Role": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Account": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Team": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Attachment": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Tag": [
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
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ticketing/v1/target-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ticketing.FieldMapping.TargetFieldsRetrieveAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ExternalTargetFieldApiResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
