using Merge.Client;
using Merge.Client.Ticketing;

namespace Merge.Client.Ticketing;

public class TicketingClient
{
    private RawClient _client;

    public TicketingClient(RawClient client)
    {
        _client = client;
        AccountDetails = new AccountDetailsClient(_client);
        AccountToken = new AccountTokenClient(_client);
        Accounts = new AccountsClient(_client);
        AsyncPassthrough = new AsyncPassthroughClient(_client);
        Attachments = new AttachmentsClient(_client);
        AuditTrail = new AuditTrailClient(_client);
        AvailableActions = new AvailableActionsClient(_client);
        Collections = new CollectionsClient(_client);
        Comments = new CommentsClient(_client);
        Contacts = new ContactsClient(_client);
        Scopes = new ScopesClient(_client);
        DeleteAccount = new DeleteAccountClient(_client);
        FieldMapping = new FieldMappingClient(_client);
        GenerateKey = new GenerateKeyClient(_client);
        Issues = new IssuesClient(_client);
        LinkToken = new LinkTokenClient(_client);
        LinkedAccounts = new LinkedAccountsClient(_client);
        Passthrough = new PassthroughClient(_client);
        Projects = new ProjectsClient(_client);
        RegenerateKey = new RegenerateKeyClient(_client);
        Roles = new RolesClient(_client);
        SelectiveSync = new SelectiveSyncClient(_client);
        SyncStatus = new SyncStatusClient(_client);
        ForceResync = new ForceResyncClient(_client);
        Tags = new TagsClient(_client);
        Teams = new TeamsClient(_client);
        Tickets = new TicketsClient(_client);
        Users = new UsersClient(_client);
        WebhookReceivers = new WebhookReceiversClient(_client);
    }

    public AccountDetailsClient AccountDetails { get; }

    public AccountTokenClient AccountToken { get; }

    public AccountsClient Accounts { get; }

    public AsyncPassthroughClient AsyncPassthrough { get; }

    public AttachmentsClient Attachments { get; }

    public AuditTrailClient AuditTrail { get; }

    public AvailableActionsClient AvailableActions { get; }

    public CollectionsClient Collections { get; }

    public CommentsClient Comments { get; }

    public ContactsClient Contacts { get; }

    public ScopesClient Scopes { get; }

    public DeleteAccountClient DeleteAccount { get; }

    public FieldMappingClient FieldMapping { get; }

    public GenerateKeyClient GenerateKey { get; }

    public IssuesClient Issues { get; }

    public LinkTokenClient LinkToken { get; }

    public LinkedAccountsClient LinkedAccounts { get; }

    public PassthroughClient Passthrough { get; }

    public ProjectsClient Projects { get; }

    public RegenerateKeyClient RegenerateKey { get; }

    public RolesClient Roles { get; }

    public SelectiveSyncClient SelectiveSync { get; }

    public SyncStatusClient SyncStatus { get; }

    public ForceResyncClient ForceResync { get; }

    public TagsClient Tags { get; }

    public TeamsClient Teams { get; }

    public TicketsClient Tickets { get; }

    public UsersClient Users { get; }

    public WebhookReceiversClient WebhookReceivers { get; }
}
