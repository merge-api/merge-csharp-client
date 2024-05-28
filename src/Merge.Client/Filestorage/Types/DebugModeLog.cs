using System.Text.Json.Serialization;
using Merge.Client.Filestorage;

#nullable enable

namespace Merge.Client.Filestorage;

public class DebugModeLog
{
    [JsonPropertyName("log_id")]
    public string LogId { get; init; }

    [JsonPropertyName("dashboard_view")]
    public string DashboardView { get; init; }

    [JsonPropertyName("log_summary")]
    public DebugModelLogSummary LogSummary { get; init; }
}
