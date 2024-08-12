using System;
using Merge.Client.Accounting;
using Merge.Client.Ats;
using Merge.Client.Core;
using Merge.Client.Crm;
using Merge.Client.Filestorage;
using Merge.Client.Hris;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client;

public partial class Merge
{
    private RawClient _client;

    public Merge(
        string? apiKey = null,
        string? accountToken = null,
        ClientOptions? clientOptions = null
    )
    {
        _client = new RawClient(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {apiKey}" },
                { "X-Account-Token", accountToken },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Merge.Client" },
                { "X-Fern-SDK-Version", "0.2.0" },
            },
            new Dictionary<string, Func<string>>() { },
            clientOptions ?? new ClientOptions()
        );
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
