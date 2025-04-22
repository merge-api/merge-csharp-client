using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record FieldMappingApiInstanceResponse
{
    [JsonPropertyName("Benefit")]
    public IEnumerable<FieldMappingApiInstance>? Benefit { get; set; }

    [JsonPropertyName("EmployerBenefit")]
    public IEnumerable<FieldMappingApiInstance>? EmployerBenefit { get; set; }

    [JsonPropertyName("Company")]
    public IEnumerable<FieldMappingApiInstance>? Company { get; set; }

    [JsonPropertyName("EmployeePayrollRun")]
    public IEnumerable<FieldMappingApiInstance>? EmployeePayrollRun { get; set; }

    [JsonPropertyName("Employee")]
    public IEnumerable<FieldMappingApiInstance>? Employee { get; set; }

    [JsonPropertyName("Employment")]
    public IEnumerable<FieldMappingApiInstance>? Employment { get; set; }

    [JsonPropertyName("Location")]
    public IEnumerable<FieldMappingApiInstance>? Location { get; set; }

    [JsonPropertyName("PayrollRun")]
    public IEnumerable<FieldMappingApiInstance>? PayrollRun { get; set; }

    [JsonPropertyName("Team")]
    public IEnumerable<FieldMappingApiInstance>? Team { get; set; }

    [JsonPropertyName("TimeOff")]
    public IEnumerable<FieldMappingApiInstance>? TimeOff { get; set; }

    [JsonPropertyName("TimeOffBalance")]
    public IEnumerable<FieldMappingApiInstance>? TimeOffBalance { get; set; }

    [JsonPropertyName("BankInfo")]
    public IEnumerable<FieldMappingApiInstance>? BankInfo { get; set; }

    [JsonPropertyName("PayGroup")]
    public IEnumerable<FieldMappingApiInstance>? PayGroup { get; set; }

    [JsonPropertyName("Group")]
    public IEnumerable<FieldMappingApiInstance>? Group { get; set; }

    [JsonPropertyName("Dependent")]
    public IEnumerable<FieldMappingApiInstance>? Dependent { get; set; }

    [JsonPropertyName("TimesheetEntry")]
    public IEnumerable<FieldMappingApiInstance>? TimesheetEntry { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
