using global::System.Threading.Tasks;
using Merge.Client.Ats;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Ats;

[TestFixture]
public class ScreeningQuestionsListTest : BaseMockServerTest
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
                  "id": "0238cbc6-6040-430a-848e-aaiehfhdbadf4ae",
                  "remote_id": "23729392",
                  "created_at": "2021-09-15T00:00:00.000Z",
                  "modified_at": "2021-10-16T00:00:00.000Z",
                  "job": "job",
                  "description": "Are you currently authorized to work for any employer in the country outlined for this role?",
                  "title": "Work Authorisation",
                  "type": "DATE",
                  "required": true,
                  "options": [
                    {
                      "remote_id": "19281",
                      "label": "I am currently authorised"
                    },
                    {
                      "remote_id": "38372",
                      "label": "I am currently not eligible"
                    }
                  ],
                  "remote_was_deleted": true
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/ats/v1/jobs/job_id/screening-questions")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var pager = await Client.Ats.Jobs.ScreeningQuestionsListAsync(
            "job_id",
            new JobsScreeningQuestionsListRequest()
        );
        await foreach (var item in pager)
        {
            Assert.That(item, Is.Not.Null);
            break; // Only check the first item
        }
    }
}
