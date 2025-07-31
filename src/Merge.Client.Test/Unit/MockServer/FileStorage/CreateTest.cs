using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.FileStorage;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.FileStorage;

[TestFixture]
public class CreateTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string requestJson = """
            {
              "event": "event",
              "is_active": true
            }
            """;

        const string mockResponse = """
            {
              "event": "event",
              "is_active": true,
              "key": "key"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/filestorage/v1/webhook-receivers")
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

        var response = await Client.FileStorage.WebhookReceivers.CreateAsync(
            new WebhookReceiverRequest { Event = "event", IsActive = true }
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<WebhookReceiver>(mockResponse)).UsingDefaults()
        );
    }
}
