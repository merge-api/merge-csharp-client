using Merge.Client.Accounting;
using Merge.Client.Ats;
using Merge.Client.Core;
using Merge.Client.Crm;
using Merge.Client.Filestorage;
using Merge.Client.Hris;
using Merge.Client.Ticketing;

namespace Merge.Client;

public partial class Merge
{
    private readonly RawClient _client;

    public Merge(
        string? apiKey = null,
        string? accountToken = null,
        ClientOptions? clientOptions = null
    )
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {apiKey}" },
                { "X-Account-Token", accountToken },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Merge.Client" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Merge.Client/1.0.3" },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        _client = new RawClient(clientOptions);
        Ats = new AtsClient(_client);
        Crm = new CrmClient(_client);
        Filestorage = new FilestorageClient(_client);
        Hris = new HrisClient(_client);
        Ticketing = new TicketingClient(_client);
        Accounting = new AccountingClient(_client);
    }

    public AtsClient Ats { get; init; }

    public CrmClient Crm { get; init; }

    public FilestorageClient Filestorage { get; init; }

    public HrisClient Hris { get; init; }

    public TicketingClient Ticketing { get; init; }

    public AccountingClient Accounting { get; init; }
}
