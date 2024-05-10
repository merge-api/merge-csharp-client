using Merge.Client.Hris;

namespace Merge.Client.Hris;

public class IgnoreCommonModelRequest
{
    public ReasonEnum Reason { get; init; }

    public string? Message { get; init; }
}
