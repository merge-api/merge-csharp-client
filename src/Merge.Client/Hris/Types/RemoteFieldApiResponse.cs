using System.Text.Json.Serialization;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class RemoteFieldApiResponse
{
    [JsonPropertyName("Benefit")]
    public List<RemoteFieldApi>? Benefit { get; init; }

    [JsonPropertyName("EmployerBenefit")]
    public List<RemoteFieldApi>? EmployerBenefit { get; init; }

    [JsonPropertyName("Company")]
    public List<RemoteFieldApi>? Company { get; init; }

    [JsonPropertyName("EmployeePayrollRun")]
    public List<RemoteFieldApi>? EmployeePayrollRun { get; init; }

    [JsonPropertyName("Employee")]
    public List<RemoteFieldApi>? Employee { get; init; }

    [JsonPropertyName("Employment")]
    public List<RemoteFieldApi>? Employment { get; init; }

    [JsonPropertyName("Location")]
    public List<RemoteFieldApi>? Location { get; init; }

    [JsonPropertyName("PayrollRun")]
    public List<RemoteFieldApi>? PayrollRun { get; init; }

    [JsonPropertyName("Team")]
    public List<RemoteFieldApi>? Team { get; init; }

    [JsonPropertyName("TimeOff")]
    public List<RemoteFieldApi>? TimeOff { get; init; }

    [JsonPropertyName("TimeOffBalance")]
    public List<RemoteFieldApi>? TimeOffBalance { get; init; }

    [JsonPropertyName("BankInfo")]
    public List<RemoteFieldApi>? BankInfo { get; init; }

    [JsonPropertyName("PayGroup")]
    public List<RemoteFieldApi>? PayGroup { get; init; }

    [JsonPropertyName("Group")]
    public List<RemoteFieldApi>? Group { get; init; }

    [JsonPropertyName("Dependent")]
    public List<RemoteFieldApi>? Dependent { get; init; }

    [JsonPropertyName("TimesheetEntry")]
    public List<RemoteFieldApi>? TimesheetEntry { get; init; }
}
