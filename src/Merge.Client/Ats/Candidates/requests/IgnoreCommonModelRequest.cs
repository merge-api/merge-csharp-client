using Merge.Client.Ats;

namespace Merge.Client.Ats;

public class IgnoreCommonModelRequest
{
    public ReasonEnum Reason { get; init; }

    public string? Message { get; init; }
}
