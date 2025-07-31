using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Hris;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Hris;

[TestFixture]
public class SyncStatusResyncCreateTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "model_name": "Employee",
                "model_id": "hris.Employee",
                "last_sync_start": "2021-03-30T19:44:18.000Z",
                "next_sync_start": "2021-03-30T20:44:18.000Z",
                "last_sync_result": "SYNCING",
                "last_sync_finished": "2021-03-30T19:55:18.000Z",
                "status": "SYNCING",
                "is_initial_sync": true,
                "selective_sync_configurations_usage": "IN_NEXT_SYNC"
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/hris/v1/sync-status/resync")
                    .UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Hris.ForceResync.SyncStatusResyncCreateAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<IEnumerable<SyncStatus>>(mockResponse)).UsingDefaults()
        );
    }
}
