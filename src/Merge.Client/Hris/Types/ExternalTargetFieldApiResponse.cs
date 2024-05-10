using System.Text.Json.Serialization;
using Merge.Client.Hris;

namespace Merge.Client.Hris;

public class ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Benefit")]
    public List<ExternalTargetFieldApi>? Benefit { get; init; }

    [JsonPropertyName("EmployerBenefit")]
    public List<ExternalTargetFieldApi>? EmployerBenefit { get; init; }

    [JsonPropertyName("Company")]
    public List<ExternalTargetFieldApi>? Company { get; init; }

    [JsonPropertyName("EmployeePayrollRun")]
    public List<ExternalTargetFieldApi>? EmployeePayrollRun { get; init; }

    [JsonPropertyName("Employee")]
    public List<ExternalTargetFieldApi>? Employee { get; init; }

    [JsonPropertyName("Employment")]
    public List<ExternalTargetFieldApi>? Employment { get; init; }

    [JsonPropertyName("Location")]
    public List<ExternalTargetFieldApi>? Location { get; init; }

    [JsonPropertyName("PayrollRun")]
    public List<ExternalTargetFieldApi>? PayrollRun { get; init; }

    [JsonPropertyName("Team")]
    public List<ExternalTargetFieldApi>? Team { get; init; }

    [JsonPropertyName("TimeOff")]
    public List<ExternalTargetFieldApi>? TimeOff { get; init; }

    [JsonPropertyName("TimeOffBalance")]
    public List<ExternalTargetFieldApi>? TimeOffBalance { get; init; }

    [JsonPropertyName("BankInfo")]
    public List<ExternalTargetFieldApi>? BankInfo { get; init; }

    [JsonPropertyName("PayGroup")]
    public List<ExternalTargetFieldApi>? PayGroup { get; init; }

    [JsonPropertyName("Group")]
    public List<ExternalTargetFieldApi>? Group { get; init; }

    [JsonPropertyName("Dependent")]
    public List<ExternalTargetFieldApi>? Dependent { get; init; }

    [JsonPropertyName("TimesheetEntry")]
    public List<ExternalTargetFieldApi>? TimesheetEntry { get; init; }
}
