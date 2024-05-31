using Merge.Client;
using Merge.Client.Accounting;
using Merge.Client.Ats;
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
        string apiKey = null,
        string? accountToken = null,
        ClientOptions clientOptions = null
    )
    {
        _client = new RawClient(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {apiKey}" },
                { "X-Account-Token", accountToken },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "Merge.Client" },
                { "X-Fern-SDK-Version", "0.0.10" },
            },
            clientOptions ?? new ClientOptions()
        );
        Ats = new AtsClient(_client);
        Filestorage = new FilestorageClient(_client);
        Crm = new CrmClient(_client);
        Ticketing = new TicketingClient(_client);
        Hris = new HrisClient(_client);
        Accounting = new AccountingClient(_client);
    }

    public AtsClient Ats { get; }

    public FilestorageClient Filestorage { get; }

    public CrmClient Crm { get; }

    public TicketingClient Ticketing { get; }

    public HrisClient Hris { get; }

    public AccountingClient Accounting { get; }

    private string GetFromEnvironmentOrThrow(string env, string message)
    {
        var value = Environment.GetEnvironmentVariable(env);
        if (value == null)
        {
            throw new Exception(message);
        }
        return value;
    }
}
