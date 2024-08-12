using System.Text.Json.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public record DebugModeLog
{
    [JsonPropertyName("log_id")]
    public required string LogId { get; set; }

    [JsonPropertyName("dashboard_view")]
    public required string DashboardView { get; set; }

    [JsonPropertyName("log_summary")]
    public required DebugModelLogSummary LogSummary { get; set; }
}
