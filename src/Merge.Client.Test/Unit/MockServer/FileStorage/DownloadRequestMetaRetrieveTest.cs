using global::System.Threading.Tasks;
using Merge.Client.Core;
using Merge.Client.FileStorage;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.FileStorage;

[TestFixture]
public class DownloadRequestMetaRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
              "url": "https://www.googleapis.com/drive/v3/files/234?alt=media",
              "method": "GET",
              "headers": {
                "Authorization": "Bearer 1234"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/filestorage/v1/files/id/download/request-meta")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.FileStorage.Files.DownloadRequestMetaRetrieveAsync(
            "id",
            new FilesDownloadRequestMetaRetrieveRequest()
        );
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<DownloadRequestMeta>(mockResponse)).UsingDefaults()
        );
    }
}
