using System.Text.Json.Serialization;
using Merge.Ats;
using Merge.Core;

namespace Merge.Ats.Candidates;

public record CandidateEndpointRequest
{
    /// <summary>
    /// Whether to include debug fields (such as log file links) in the response.
    /// </summary>
    [JsonIgnore]
    public bool? IsDebugMode { get; set; }

    /// <summary>
    /// Whether or not third-party updates should be run asynchronously.
    /// </summary>
    [JsonIgnore]
    public bool? RunAsync { get; set; }

    [JsonPropertyName("model")]
    public required CandidateRequest Model { get; set; }

    [JsonPropertyName("remote_user_id")]
    public required string RemoteUserId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
