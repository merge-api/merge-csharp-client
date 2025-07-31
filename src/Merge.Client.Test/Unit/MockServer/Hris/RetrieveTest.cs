using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Hris;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Hris;

[TestFixture]
public class RetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "id": "91b2b905-e866-40c8-8be2-efe53827a0aa",
              "remote_id": "19202938",
              "created_at": "2021-09-15T00:00:00.000Z",
              "modified_at": "2021-10-16T00:00:00.000Z",
              "employee": "employee",
              "hours_worked": 10,
              "start_time": "2020-11-10T00:00:00.000Z",
              "end_time": "2020-11-10T00:10:00.000Z",
              "remote_was_deleted": true,
              "field_mappings": {
                "organization_defined_targets": {
                  "custom_key": "custom_value"
                },
                "linked_account_defined_targets": {
                  "custom_key": "custom_value"
                }
              },
              "remote_data": [
                {
                  "path": "/dependent",
                  "data": [
                    "Varies by platform"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/hris/v1/timesheet-entries/id")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Hris.TimesheetEntries.RetrieveAsync(
            "id",
            new TimesheetEntriesRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<TimesheetEntry>(mockResponse)).UsingDefaults()
        );
    }
}
