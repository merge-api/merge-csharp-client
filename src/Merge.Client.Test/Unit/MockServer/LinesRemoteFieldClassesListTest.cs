using global::System.Threading.Tasks;
using Merge.Client.Accounting;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer;

[TestFixture]
public class LinesRemoteFieldClassesListTest : BaseMockServerTest
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
                  "id": "id",
                  "display_name": "display_name",
                  "remote_key_name": "remote_key_name",
                  "description": "description",
                  "is_custom": true,
                  "is_required": true,
                  "field_type": "string",
                  "field_format": "string",
                  "field_choices": [
                    "field_choices"
                  ]
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/accounting/v1/journal-entries/lines/remote-field-classes")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var pager = await Client.Accounting.JournalEntries.LinesRemoteFieldClassesListAsync(
            new JournalEntriesLinesRemoteFieldClassesListRequest()
        );
        await foreach (var item in pager)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
