using System.Text.Json.Serialization;
using Merge.Client.Hris;

namespace Merge.Client.Hris;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Benefit")]
    public List<FieldMappingApiInstance>? Benefit { get; init; }

    [JsonPropertyName("EmployerBenefit")]
    public List<FieldMappingApiInstance>? EmployerBenefit { get; init; }

    [JsonPropertyName("Company")]
    public List<FieldMappingApiInstance>? Company { get; init; }

    [JsonPropertyName("EmployeePayrollRun")]
    public List<FieldMappingApiInstance>? EmployeePayrollRun { get; init; }

    [JsonPropertyName("Employee")]
    public List<FieldMappingApiInstance>? Employee { get; init; }

    [JsonPropertyName("Employment")]
    public List<FieldMappingApiInstance>? Employment { get; init; }

    [JsonPropertyName("Location")]
    public List<FieldMappingApiInstance>? Location { get; init; }

    [JsonPropertyName("PayrollRun")]
    public List<FieldMappingApiInstance>? PayrollRun { get; init; }

    [JsonPropertyName("Team")]
    public List<FieldMappingApiInstance>? Team { get; init; }

    [JsonPropertyName("TimeOff")]
    public List<FieldMappingApiInstance>? TimeOff { get; init; }

    [JsonPropertyName("TimeOffBalance")]
    public List<FieldMappingApiInstance>? TimeOffBalance { get; init; }

    [JsonPropertyName("BankInfo")]
    public List<FieldMappingApiInstance>? BankInfo { get; init; }

    [JsonPropertyName("PayGroup")]
    public List<FieldMappingApiInstance>? PayGroup { get; init; }

    [JsonPropertyName("Group")]
    public List<FieldMappingApiInstance>? Group { get; init; }

    [JsonPropertyName("Dependent")]
    public List<FieldMappingApiInstance>? Dependent { get; init; }

    [JsonPropertyName("TimesheetEntry")]
    public List<FieldMappingApiInstance>? TimesheetEntry { get; init; }
}
