namespace Merge.Client.Hris;

public class WebhookReceiverRequest
{
    public string Event { get; init; }

    public bool IsActive { get; init; }

    public string? Key { get; init; }
}
