using global::System.Threading.Tasks;
using Merge.Client.Accounting;
using Merge.Client.Core;
using Merge.Client.Test.Unit.MockServer;
using NUnit.Framework;

namespace Merge.Client.Test.Unit.MockServer.Accounting;

[TestFixture]
public class TargetFieldsRetrieveTest : BaseMockServerTest
{
    [Test]
    public async global::System.Threading.Tasks.Task MockServerTest()
    {
        const string mockResponse = """
            {
              "Account": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "AccountingAttachment": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "BalanceSheet": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "CashFlowStatement": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "CompanyInfo": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Contact": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "IncomeStatement": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "CreditNote": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Item": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "PurchaseOrder": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "TrackingCategory": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "JournalEntry": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "TaxRate": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Invoice": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Payment": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Expense": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "VendorCredit": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Transaction": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "AccountingPeriod": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "GeneralLedgerTransaction": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "BankFeedAccount": [
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
              "PaymentMethod": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "Project": [
                {
                  "name": "example_target_field_name",
                  "description": "this is a example description of a target field",
                  "is_mapped": "is_mapped"
                }
              ],
              "PaymentTerm": [
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
                    .WithPath("/accounting/v1/target-fields")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Accounting.FieldMapping.TargetFieldsRetrieveAsync();
        Assert.That(
            response,
            Is.EqualTo(JsonUtils.Deserialize<ExternalTargetFieldApiResponse>(mockResponse))
                .UsingDefaults()
        );
    }
}
