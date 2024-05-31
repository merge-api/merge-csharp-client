using System.Text.Json.Serialization;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("Benefit")]
    public IEnumerable<RemoteFieldApi>? Benefit { get; init; }

    [JsonPropertyName("EmployerBenefit")]
    public IEnumerable<RemoteFieldApi>? EmployerBenefit { get; init; }

    [JsonPropertyName("Company")]
    public IEnumerable<RemoteFieldApi>? Company { get; init; }

    [JsonPropertyName("EmployeePayrollRun")]
    public IEnumerable<RemoteFieldApi>? EmployeePayrollRun { get; init; }

    [JsonPropertyName("Employee")]
    public IEnumerable<RemoteFieldApi>? Employee { get; init; }

    [JsonPropertyName("Employment")]
    public IEnumerable<RemoteFieldApi>? Employment { get; init; }

    [JsonPropertyName("Location")]
    public IEnumerable<RemoteFieldApi>? Location { get; init; }

    [JsonPropertyName("PayrollRun")]
    public IEnumerable<RemoteFieldApi>? PayrollRun { get; init; }

    [JsonPropertyName("Team")]
    public IEnumerable<RemoteFieldApi>? Team { get; init; }

    [JsonPropertyName("TimeOff")]
    public IEnumerable<RemoteFieldApi>? TimeOff { get; init; }

    [JsonPropertyName("TimeOffBalance")]
    public IEnumerable<RemoteFieldApi>? TimeOffBalance { get; init; }

    [JsonPropertyName("BankInfo")]
    public IEnumerable<RemoteFieldApi>? BankInfo { get; init; }

    [JsonPropertyName("PayGroup")]
    public IEnumerable<RemoteFieldApi>? PayGroup { get; init; }

    [JsonPropertyName("Group")]
    public IEnumerable<RemoteFieldApi>? Group { get; init; }

    [JsonPropertyName("Dependent")]
    public IEnumerable<RemoteFieldApi>? Dependent { get; init; }

    [JsonPropertyName("TimesheetEntry")]
    public IEnumerable<RemoteFieldApi>? TimesheetEntry { get; init; }
}
