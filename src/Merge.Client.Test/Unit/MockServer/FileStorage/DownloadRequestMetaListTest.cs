using global::System.Threading.Tasks;
using Merge.Client.FileStorage;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.FileStorage;

[TestFixture]
public class DownloadRequestMetaListTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "next": "cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw",
              "previous": "cj1sZXdwd2VycWVtY29zZnNkc2NzUWxNMEUxTXk0ME16UXpNallsTWtJ",
              "results": [
                {
                  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
                  "url": "https://www.googleapis.com/drive/v3/files/234?alt=media",
                  "method": "GET",
                  "headers": {
                    "Authorization": "Bearer 1234"
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/filestorage/v1/files/download/request-meta")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var pager = await Client.FileStorage.Files.DownloadRequestMetaListAsync(
            new FilesDownloadRequestMetaListRequest()
        );
        await foreach (var item in pager)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
