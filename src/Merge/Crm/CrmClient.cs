using Merge.Core;
using Merge.Crm.AccountDetails;
using Merge.Crm.Accounts;
using Merge.Crm.AccountToken;
using Merge.Crm.Associations;
using Merge.Crm.AssociationTypes;
using Merge.Crm.AsyncPassthrough;
using Merge.Crm.AuditTrail;
using Merge.Crm.AvailableActions;
using Merge.Crm.Contacts;
using Merge.Crm.CustomObjectClasses;
using Merge.Crm.CustomObjects;
using Merge.Crm.DeleteAccount;
using Merge.Crm.Engagements;
using Merge.Crm.EngagementTypes;
using Merge.Crm.FieldMapping;
using Merge.Crm.ForceResync;
using Merge.Crm.GenerateKey;
using Merge.Crm.Issues;
using Merge.Crm.Leads;
using Merge.Crm.LinkedAccounts;
using Merge.Crm.LinkToken;
using Merge.Crm.Notes;
using Merge.Crm.Opportunities;
using Merge.Crm.Passthrough;
using Merge.Crm.RegenerateKey;
using Merge.Crm.Scopes;
using Merge.Crm.Stages;
using Merge.Crm.SyncStatus;
using Merge.Crm.Tasks;
using Merge.Crm.Users;
using Merge.Crm.WebhookReceivers;

namespace Merge.Crm;

public partial class CrmClient
{
    private RawClient _client;

    internal CrmClient(RawClient client)
    {
        _client = client;
        AccountDetails = new AccountDetailsClient(_client);
        AccountToken = new AccountTokenClient(_client);
        Accounts = new AccountsClient(_client);
        AsyncPassthrough = new AsyncPassthroughClient(_client);
        AuditTrail = new AuditTrailClient(_client);
        AvailableActions = new AvailableActionsClient(_client);
        Contacts = new ContactsClient(_client);
        CustomObjectClasses = new CustomObjectClassesClient(_client);
        AssociationTypes = new AssociationTypesClient(_client);
        CustomObjects = new CustomObjectsClient(_client);
        Associations = new AssociationsClient(_client);
        Scopes = new ScopesClient(_client);
        DeleteAccount = new DeleteAccountClient(_client);
        EngagementTypes = new EngagementTypesClient(_client);
        Engagements = new EngagementsClient(_client);
        FieldMapping = new FieldMappingClient(_client);
        GenerateKey = new GenerateKeyClient(_client);
        Issues = new IssuesClient(_client);
        Leads = new LeadsClient(_client);
        LinkToken = new LinkTokenClient(_client);
        LinkedAccounts = new LinkedAccountsClient(_client);
        Notes = new NotesClient(_client);
        Opportunities = new OpportunitiesClient(_client);
        Passthrough = new PassthroughClient(_client);
        RegenerateKey = new RegenerateKeyClient(_client);
        Stages = new StagesClient(_client);
        SyncStatus = new SyncStatusClient(_client);
        ForceResync = new ForceResyncClient(_client);
        Tasks = new TasksClient(_client);
        Users = new UsersClient(_client);
        WebhookReceivers = new WebhookReceiversClient(_client);
    }

    public AccountDetailsClient AccountDetails { get; }

    public AccountTokenClient AccountToken { get; }

    public AccountsClient Accounts { get; }

    public AsyncPassthroughClient AsyncPassthrough { get; }

    public AuditTrailClient AuditTrail { get; }

    public AvailableActionsClient AvailableActions { get; }

    public ContactsClient Contacts { get; }

    public CustomObjectClassesClient CustomObjectClasses { get; }

    public AssociationTypesClient AssociationTypes { get; }

    public CustomObjectsClient CustomObjects { get; }

    public AssociationsClient Associations { get; }

    public ScopesClient Scopes { get; }

    public DeleteAccountClient DeleteAccount { get; }

    public EngagementTypesClient EngagementTypes { get; }

    public EngagementsClient Engagements { get; }

    public FieldMappingClient FieldMapping { get; }

    public GenerateKeyClient GenerateKey { get; }

    public IssuesClient Issues { get; }

    public LeadsClient Leads { get; }

    public LinkTokenClient LinkToken { get; }

    public LinkedAccountsClient LinkedAccounts { get; }

    public NotesClient Notes { get; }

    public OpportunitiesClient Opportunities { get; }

    public PassthroughClient Passthrough { get; }

    public RegenerateKeyClient RegenerateKey { get; }

    public StagesClient Stages { get; }

    public SyncStatusClient SyncStatus { get; }

    public ForceResyncClient ForceResync { get; }

    public TasksClient Tasks { get; }

    public UsersClient Users { get; }

    public WebhookReceiversClient WebhookReceivers { get; }
}
