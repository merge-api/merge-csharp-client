using System.Text.Json.Serialization;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Benefit")]
    public IEnumerable<ExternalTargetFieldApi>? Benefit { get; init; }

    [JsonPropertyName("EmployerBenefit")]
    public IEnumerable<ExternalTargetFieldApi>? EmployerBenefit { get; init; }

    [JsonPropertyName("Company")]
    public IEnumerable<ExternalTargetFieldApi>? Company { get; init; }

    [JsonPropertyName("EmployeePayrollRun")]
    public IEnumerable<ExternalTargetFieldApi>? EmployeePayrollRun { get; init; }

    [JsonPropertyName("Employee")]
    public IEnumerable<ExternalTargetFieldApi>? Employee { get; init; }

    [JsonPropertyName("Employment")]
    public IEnumerable<ExternalTargetFieldApi>? Employment { get; init; }

    [JsonPropertyName("Location")]
    public IEnumerable<ExternalTargetFieldApi>? Location { get; init; }

    [JsonPropertyName("PayrollRun")]
    public IEnumerable<ExternalTargetFieldApi>? PayrollRun { get; init; }

    [JsonPropertyName("Team")]
    public IEnumerable<ExternalTargetFieldApi>? Team { get; init; }

    [JsonPropertyName("TimeOff")]
    public IEnumerable<ExternalTargetFieldApi>? TimeOff { get; init; }

    [JsonPropertyName("TimeOffBalance")]
    public IEnumerable<ExternalTargetFieldApi>? TimeOffBalance { get; init; }

    [JsonPropertyName("BankInfo")]
    public IEnumerable<ExternalTargetFieldApi>? BankInfo { get; init; }

    [JsonPropertyName("PayGroup")]
    public IEnumerable<ExternalTargetFieldApi>? PayGroup { get; init; }

    [JsonPropertyName("Group")]
    public IEnumerable<ExternalTargetFieldApi>? Group { get; init; }

    [JsonPropertyName("Dependent")]
    public IEnumerable<ExternalTargetFieldApi>? Dependent { get; init; }

    [JsonPropertyName("TimesheetEntry")]
    public IEnumerable<ExternalTargetFieldApi>? TimesheetEntry { get; init; }
}
