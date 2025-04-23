using Merge.Client.Accounting;
using Merge.Client.Ats;
using Merge.Client.Core;
using Merge.Client.Crm;
using Merge.Client.Filestorage;
using Merge.Client.Hris;
using Merge.Client.Ticketing;

namespace Merge.Client;

internal partial class BaseMergeClient
{
    private readonly RawClient _client;

    public BaseMergeClient(
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
                { "User-Agent", "Merge.Client/1.1.0" },
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
        Crm = new CrmClient(_client);
        Ats = new AtsClient(_client);
        Hris = new HrisClient(_client);
        Filestorage = new FilestorageClient(_client);
        Ticketing = new TicketingClient(_client);
        Accounting = new AccountingClient(_client);
    }

    public CrmClient Crm { get; }

    public AtsClient Ats { get; }

    public HrisClient Hris { get; }

    public FilestorageClient Filestorage { get; }

    public TicketingClient Ticketing { get; }

    public AccountingClient Accounting { get; }
}
