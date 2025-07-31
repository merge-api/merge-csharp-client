using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Hris;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Hris;

[TestFixture]
public class TargetFieldsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Benefit": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "EmployerBenefit": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Company": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "EmployeePayrollRun": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Employee": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Employment": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Location": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "PayrollRun": [
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
              "TimeOff": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "TimeOffBalance": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "BankInfo": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "PayGroup": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Group": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Dependent": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "TimesheetEntry": [
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
                    .WithPath("/hris/v1/target-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Hris.FieldMapping.TargetFieldsRetrieveAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ExternalTargetFieldApiResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
