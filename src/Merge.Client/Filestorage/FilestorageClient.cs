using Merge.Client;
using Merge.Client.Filestorage;

namespace Merge.Client.Filestorage;

public class FilestorageClient
{
    private RawClient _client;

    public FilestorageClient(RawClient client)
    {
        _client = client;
        AccountDetails = new AccountDetailsClient(_client);
        AccountToken = new AccountTokenClient(_client);
        AsyncPassthrough = new AsyncPassthroughClient(_client);
        AuditTrail = new AuditTrailClient(_client);
        AvailableActions = new AvailableActionsClient(_client);
        Scopes = new ScopesClient(_client);
        DeleteAccount = new DeleteAccountClient(_client);
        Drives = new DrivesClient(_client);
        FieldMapping = new FieldMappingClient(_client);
        Files = new FilesClient(_client);
        Folders = new FoldersClient(_client);
        GenerateKey = new GenerateKeyClient(_client);
        Groups = new GroupsClient(_client);
        Issues = new IssuesClient(_client);
        LinkToken = new LinkTokenClient(_client);
        LinkedAccounts = new LinkedAccountsClient(_client);
        Passthrough = new PassthroughClient(_client);
        RegenerateKey = new RegenerateKeyClient(_client);
        SyncStatus = new SyncStatusClient(_client);
        ForceResync = new ForceResyncClient(_client);
        Users = new UsersClient(_client);
        WebhookReceivers = new WebhookReceiversClient(_client);
    }

    public AccountDetailsClient AccountDetails { get; }

    public AccountTokenClient AccountToken { get; }

    public AsyncPassthroughClient AsyncPassthrough { get; }

    public AuditTrailClient AuditTrail { get; }

    public AvailableActionsClient AvailableActions { get; }

    public ScopesClient Scopes { get; }

    public DeleteAccountClient DeleteAccount { get; }

    public DrivesClient Drives { get; }

    public FieldMappingClient FieldMapping { get; }

    public FilesClient Files { get; }

    public FoldersClient Folders { get; }

    public GenerateKeyClient GenerateKey { get; }

    public GroupsClient Groups { get; }

    public IssuesClient Issues { get; }

    public LinkTokenClient LinkToken { get; }

    public LinkedAccountsClient LinkedAccounts { get; }

    public PassthroughClient Passthrough { get; }

    public RegenerateKeyClient RegenerateKey { get; }

    public SyncStatusClient SyncStatus { get; }

    public ForceResyncClient ForceResync { get; }

    public UsersClient Users { get; }

    public WebhookReceiversClient WebhookReceivers { get; }
}
