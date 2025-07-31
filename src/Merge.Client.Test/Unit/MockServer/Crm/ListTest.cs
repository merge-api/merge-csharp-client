using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.Crm;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Crm;

[TestFixture]
public class ListTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            [
              {
                "event": "event",
                "is_active": true,
                "key": "key"
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/crm/v1/webhook-receivers")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Crm.WebhookReceivers.ListAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<IEnumerable<WebhookReceiver>>(mockResponse))
                .UsingDefaults()
        );
    }
}
