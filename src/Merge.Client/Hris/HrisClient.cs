using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Hris;

public class HrisClient
{
    private RawClient _client;

    public HrisClient(RawClient client)
    {
        _client = client;
        AccountDetails = new AccountDetailsClient(_client);
        AccountToken = new AccountTokenClient(_client);
        AsyncPassthrough = new AsyncPassthroughClient(_client);
        AuditTrail = new AuditTrailClient(_client);
        AvailableActions = new AvailableActionsClient(_client);
        BankInfo = new BankInfoClient(_client);
        Benefits = new BenefitsClient(_client);
        Companies = new CompaniesClient(_client);
        Scopes = new ScopesClient(_client);
        DeleteAccount = new DeleteAccountClient(_client);
        Dependents = new DependentsClient(_client);
        EmployeePayrollRuns = new EmployeePayrollRunsClient(_client);
        Employees = new EmployeesClient(_client);
        EmployerBenefits = new EmployerBenefitsClient(_client);
        Employments = new EmploymentsClient(_client);
        FieldMapping = new FieldMappingClient(_client);
        GenerateKey = new GenerateKeyClient(_client);
        Groups = new GroupsClient(_client);
        Issues = new IssuesClient(_client);
        LinkToken = new LinkTokenClient(_client);
        LinkedAccounts = new LinkedAccountsClient(_client);
        Locations = new LocationsClient(_client);
        Passthrough = new PassthroughClient(_client);
        PayGroups = new PayGroupsClient(_client);
        PayrollRuns = new PayrollRunsClient(_client);
        RegenerateKey = new RegenerateKeyClient(_client);
        SyncStatus = new SyncStatusClient(_client);
        ForceResync = new ForceResyncClient(_client);
        Teams = new TeamsClient(_client);
        TimeOff = new TimeOffClient(_client);
        TimeOffBalances = new TimeOffBalancesClient(_client);
        TimesheetEntries = new TimesheetEntriesClient(_client);
        WebhookReceivers = new WebhookReceiversClient(_client);
    }

    public AccountDetailsClient AccountDetails { get; }

    public AccountTokenClient AccountToken { get; }

    public AsyncPassthroughClient AsyncPassthrough { get; }

    public AuditTrailClient AuditTrail { get; }

    public AvailableActionsClient AvailableActions { get; }

    public BankInfoClient BankInfo { get; }

    public BenefitsClient Benefits { get; }

    public CompaniesClient Companies { get; }

    public ScopesClient Scopes { get; }

    public DeleteAccountClient DeleteAccount { get; }

    public DependentsClient Dependents { get; }

    public EmployeePayrollRunsClient EmployeePayrollRuns { get; }

    public EmployeesClient Employees { get; }

    public EmployerBenefitsClient EmployerBenefits { get; }

    public EmploymentsClient Employments { get; }

    public FieldMappingClient FieldMapping { get; }

    public GenerateKeyClient GenerateKey { get; }

    public GroupsClient Groups { get; }

    public IssuesClient Issues { get; }

    public LinkTokenClient LinkToken { get; }

    public LinkedAccountsClient LinkedAccounts { get; }

    public LocationsClient Locations { get; }

    public PassthroughClient Passthrough { get; }

    public PayGroupsClient PayGroups { get; }

    public PayrollRunsClient PayrollRuns { get; }

    public RegenerateKeyClient RegenerateKey { get; }

    public SyncStatusClient SyncStatus { get; }

    public ForceResyncClient ForceResync { get; }

    public TeamsClient Teams { get; }

    public TimeOffClient TimeOff { get; }

    public TimeOffBalancesClient TimeOffBalances { get; }

    public TimesheetEntriesClient TimesheetEntries { get; }

    public WebhookReceiversClient WebhookReceivers { get; }
}
