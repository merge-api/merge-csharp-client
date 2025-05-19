using System.Text.Json;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

public record ExternalTargetFieldApiResponse
{
    [JsonPropertyName("Benefit")]
    public IEnumerable<ExternalTargetFieldApi>? Benefit { get; set; }

    [JsonPropertyName("EmployerBenefit")]
    public IEnumerable<ExternalTargetFieldApi>? EmployerBenefit { get; set; }

    [JsonPropertyName("Company")]
    public IEnumerable<ExternalTargetFieldApi>? Company { get; set; }

    [JsonPropertyName("EmployeePayrollRun")]
    public IEnumerable<ExternalTargetFieldApi>? EmployeePayrollRun { get; set; }

    [JsonPropertyName("Employee")]
    public IEnumerable<ExternalTargetFieldApi>? Employee { get; set; }

    [JsonPropertyName("Employment")]
    public IEnumerable<ExternalTargetFieldApi>? Employment { get; set; }

    [JsonPropertyName("Location")]
    public IEnumerable<ExternalTargetFieldApi>? Location { get; set; }

    [JsonPropertyName("PayrollRun")]
    public IEnumerable<ExternalTargetFieldApi>? PayrollRun { get; set; }

    [JsonPropertyName("Team")]
    public IEnumerable<ExternalTargetFieldApi>? Team { get; set; }

    [JsonPropertyName("TimeOff")]
    public IEnumerable<ExternalTargetFieldApi>? TimeOff { get; set; }

    [JsonPropertyName("TimeOffBalance")]
    public IEnumerable<ExternalTargetFieldApi>? TimeOffBalance { get; set; }

    [JsonPropertyName("BankInfo")]
    public IEnumerable<ExternalTargetFieldApi>? BankInfo { get; set; }

    [JsonPropertyName("PayGroup")]
    public IEnumerable<ExternalTargetFieldApi>? PayGroup { get; set; }

    [JsonPropertyName("Group")]
    public IEnumerable<ExternalTargetFieldApi>? Group { get; set; }

    [JsonPropertyName("Dependent")]
    public IEnumerable<ExternalTargetFieldApi>? Dependent { get; set; }

    [JsonPropertyName("TimesheetEntry")]
    public IEnumerable<ExternalTargetFieldApi>? TimesheetEntry { get; set; }

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
