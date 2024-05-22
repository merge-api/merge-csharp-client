using Merge.Client;
using Merge.Client.Accounting;
using Merge.Client.Ats;
using Merge.Client.Crm;
using Merge.Client.Filestorage;
using Merge.Client.Hris;
using Merge.Client.Ticketing;

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
                { "X-Fern-SDK-Name", "merge_fern_api_sdk" },
                { "X-Fern-SDK-Version", "v0.0.5" },
            },
            clientOptions ?? new ClientOptions()
        );
        Ats = new AtsClient(_client);
        Crm = new CrmClient(_client);
        Filestorage = new FilestorageClient(_client);
        Hris = new HrisClient(_client);
        Ticketing = new TicketingClient(_client);
        Accounting = new AccountingClient(_client);
    }

    public AtsClient Ats { get; }

    public CrmClient Crm { get; }

    public FilestorageClient Filestorage { get; }

    public HrisClient Hris { get; }

    public TicketingClient Ticketing { get; }

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
