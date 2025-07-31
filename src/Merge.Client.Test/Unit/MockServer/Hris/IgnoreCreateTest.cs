using Merge.Client.Hris;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Hris;

[TestFixture]
public class IgnoreCreateTest : BaseMockServerTest
{
    [Test]
    public void MockServerTest()
    {
        const string requestJson = """
            {
              "reason": "GENERAL_CUSTOMER_REQUEST"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/hris/v1/employees/ignore/model_id")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Hris.Employees.IgnoreCreateAsync(
                "model_id",
                new IgnoreCommonModelRequest { Reason = ReasonEnum.GeneralCustomerRequest }
            )
        );
    }
}
