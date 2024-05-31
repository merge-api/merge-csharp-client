using System.Text.Json.Serialization;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

public class FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Benefit")]
    public IEnumerable<FieldMappingApiInstance>? Benefit { get; init; }

    [JsonPropertyName("EmployerBenefit")]
    public IEnumerable<FieldMappingApiInstance>? EmployerBenefit { get; init; }

    [JsonPropertyName("Company")]
    public IEnumerable<FieldMappingApiInstance>? Company { get; init; }

    [JsonPropertyName("EmployeePayrollRun")]
    public IEnumerable<FieldMappingApiInstance>? EmployeePayrollRun { get; init; }

    [JsonPropertyName("Employee")]
    public IEnumerable<FieldMappingApiInstance>? Employee { get; init; }

    [JsonPropertyName("Employment")]
    public IEnumerable<FieldMappingApiInstance>? Employment { get; init; }

    [JsonPropertyName("Location")]
    public IEnumerable<FieldMappingApiInstance>? Location { get; init; }

    [JsonPropertyName("PayrollRun")]
    public IEnumerable<FieldMappingApiInstance>? PayrollRun { get; init; }

    [JsonPropertyName("Team")]
    public IEnumerable<FieldMappingApiInstance>? Team { get; init; }

    [JsonPropertyName("TimeOff")]
    public IEnumerable<FieldMappingApiInstance>? TimeOff { get; init; }

    [JsonPropertyName("TimeOffBalance")]
    public IEnumerable<FieldMappingApiInstance>? TimeOffBalance { get; init; }

    [JsonPropertyName("BankInfo")]
    public IEnumerable<FieldMappingApiInstance>? BankInfo { get; init; }

    [JsonPropertyName("PayGroup")]
    public IEnumerable<FieldMappingApiInstance>? PayGroup { get; init; }

    [JsonPropertyName("Group")]
    public IEnumerable<FieldMappingApiInstance>? Group { get; init; }

    [JsonPropertyName("Dependent")]
    public IEnumerable<FieldMappingApiInstance>? Dependent { get; init; }

    [JsonPropertyName("TimesheetEntry")]
    public IEnumerable<FieldMappingApiInstance>? TimesheetEntry { get; init; }
}
