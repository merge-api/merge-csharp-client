using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ticketing;

public record DebugModeLog
{
    [JsonPropertyName("log_id")]
    public required string LogId { get; set; }

    [JsonPropertyName("dashboard_view")]
    public required string DashboardView { get; set; }

    [JsonPropertyName("log_summary")]
    public required DebugModelLogSummary LogSummary { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
