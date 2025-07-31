using global::System.Threading.Tasks;
using Merge.Client.Ats;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ats;

[TestFixture]
public class TargetFieldsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Activity": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Application": [
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
              "Candidate": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Department": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "EEOC": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "ScheduledInterview": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Job": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "JobPosting": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "JobInterviewStage": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Offer": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Office": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "RejectReason": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Scorecard": [
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
              "RemoteUser": [
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
                    .WithPath("/ats/v1/target-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Ats.FieldMapping.TargetFieldsRetrieveAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ExternalTargetFieldApiResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
