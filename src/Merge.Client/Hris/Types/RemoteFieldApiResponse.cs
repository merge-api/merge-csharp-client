using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record RemoteFieldApiResponse
{
    [JsonPropertyName("Benefit")]
    public IEnumerable<RemoteFieldApi>? Benefit { get; set; }

    [JsonPropertyName("EmployerBenefit")]
    public IEnumerable<RemoteFieldApi>? EmployerBenefit { get; set; }

    [JsonPropertyName("Company")]
    public IEnumerable<RemoteFieldApi>? Company { get; set; }

    [JsonPropertyName("EmployeePayrollRun")]
    public IEnumerable<RemoteFieldApi>? EmployeePayrollRun { get; set; }

    [JsonPropertyName("Employee")]
    public IEnumerable<RemoteFieldApi>? Employee { get; set; }

    [JsonPropertyName("Employment")]
    public IEnumerable<RemoteFieldApi>? Employment { get; set; }

    [JsonPropertyName("Location")]
    public IEnumerable<RemoteFieldApi>? Location { get; set; }

    [JsonPropertyName("PayrollRun")]
    public IEnumerable<RemoteFieldApi>? PayrollRun { get; set; }

    [JsonPropertyName("Team")]
    public IEnumerable<RemoteFieldApi>? Team { get; set; }

    [JsonPropertyName("TimeOff")]
    public IEnumerable<RemoteFieldApi>? TimeOff { get; set; }

    [JsonPropertyName("TimeOffBalance")]
    public IEnumerable<RemoteFieldApi>? TimeOffBalance { get; set; }

    [JsonPropertyName("BankInfo")]
    public IEnumerable<RemoteFieldApi>? BankInfo { get; set; }

    [JsonPropertyName("PayGroup")]
    public IEnumerable<RemoteFieldApi>? PayGroup { get; set; }

    [JsonPropertyName("Group")]
    public IEnumerable<RemoteFieldApi>? Group { get; set; }

    [JsonPropertyName("Dependent")]
    public IEnumerable<RemoteFieldApi>? Dependent { get; set; }

    [JsonPropertyName("TimesheetEntry")]
    public IEnumerable<RemoteFieldApi>? TimesheetEntry { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
