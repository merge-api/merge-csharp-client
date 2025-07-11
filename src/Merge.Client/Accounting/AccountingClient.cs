using Merge.Client.Core;

namespace Merge.Client.Accounting;

public partial class AccountingClient
{
    private RawClient _client;

    internal AccountingClient(RawClient client)
    {
        _client = client;
        AccountDetails = new AccountDetailsClient(_client);
        AccountToken = new AccountTokenClient(_client);
        AccountingPeriods = new AccountingPeriodsClient(_client);
        Accounts = new AccountsClient(_client);
        Addresses = new AddressesClient(_client);
        AsyncPassthrough = new AsyncPassthroughClient(_client);
        AsyncTasks = new AsyncTasksClient(_client);
        Attachments = new AttachmentsClient(_client);
        AuditTrail = new AuditTrailClient(_client);
        AvailableActions = new AvailableActionsClient(_client);
        BalanceSheets = new BalanceSheetsClient(_client);
        BankFeedAccounts = new BankFeedAccountsClient(_client);
        BankFeedTransactions = new BankFeedTransactionsClient(_client);
        CashFlowStatements = new CashFlowStatementsClient(_client);
        CompanyInfo = new CompanyInfoClient(_client);
        Contacts = new ContactsClient(_client);
        CreditNotes = new CreditNotesClient(_client);
        Scopes = new ScopesClient(_client);
        DeleteAccount = new DeleteAccountClient(_client);
        Employees = new EmployeesClient(_client);
        Expenses = new ExpensesClient(_client);
        FieldMapping = new FieldMappingClient(_client);
        GeneralLedgerTransactions = new GeneralLedgerTransactionsClient(_client);
        GenerateKey = new GenerateKeyClient(_client);
        IncomeStatements = new IncomeStatementsClient(_client);
        Invoices = new InvoicesClient(_client);
        Issues = new IssuesClient(_client);
        Items = new ItemsClient(_client);
        JournalEntries = new JournalEntriesClient(_client);
        LinkToken = new LinkTokenClient(_client);
        LinkedAccounts = new LinkedAccountsClient(_client);
        Passthrough = new PassthroughClient(_client);
        PaymentMethods = new PaymentMethodsClient(_client);
        PaymentTerms = new PaymentTermsClient(_client);
        Payments = new PaymentsClient(_client);
        PhoneNumbers = new PhoneNumbersClient(_client);
        Projects = new ProjectsClient(_client);
        PurchaseOrders = new PurchaseOrdersClient(_client);
        RegenerateKey = new RegenerateKeyClient(_client);
        SyncStatus = new SyncStatusClient(_client);
        ForceResync = new ForceResyncClient(_client);
        TaxRates = new TaxRatesClient(_client);
        TrackingCategories = new TrackingCategoriesClient(_client);
        Transactions = new TransactionsClient(_client);
        VendorCredits = new VendorCreditsClient(_client);
        WebhookReceivers = new WebhookReceiversClient(_client);
    }

    public AccountDetailsClient AccountDetails { get; }

    public AccountTokenClient AccountToken { get; }

    public AccountingPeriodsClient AccountingPeriods { get; }

    public AccountsClient Accounts { get; }

    public AddressesClient Addresses { get; }

    public AsyncPassthroughClient AsyncPassthrough { get; }

    public AsyncTasksClient AsyncTasks { get; }

    public AttachmentsClient Attachments { get; }

    public AuditTrailClient AuditTrail { get; }

    public AvailableActionsClient AvailableActions { get; }

    public BalanceSheetsClient BalanceSheets { get; }

    public BankFeedAccountsClient BankFeedAccounts { get; }

    public BankFeedTransactionsClient BankFeedTransactions { get; }

    public CashFlowStatementsClient CashFlowStatements { get; }

    public CompanyInfoClient CompanyInfo { get; }

    public ContactsClient Contacts { get; }

    public CreditNotesClient CreditNotes { get; }

    public ScopesClient Scopes { get; }

    public DeleteAccountClient DeleteAccount { get; }

    public EmployeesClient Employees { get; }

    public ExpensesClient Expenses { get; }

    public FieldMappingClient FieldMapping { get; }

    public GeneralLedgerTransactionsClient GeneralLedgerTransactions { get; }

    public GenerateKeyClient GenerateKey { get; }

    public IncomeStatementsClient IncomeStatements { get; }

    public InvoicesClient Invoices { get; }

    public IssuesClient Issues { get; }

    public ItemsClient Items { get; }

    public JournalEntriesClient JournalEntries { get; }

    public LinkTokenClient LinkToken { get; }

    public LinkedAccountsClient LinkedAccounts { get; }

    public PassthroughClient Passthrough { get; }

    public PaymentMethodsClient PaymentMethods { get; }

    public PaymentTermsClient PaymentTerms { get; }

    public PaymentsClient Payments { get; }

    public PhoneNumbersClient PhoneNumbers { get; }

    public ProjectsClient Projects { get; }

    public PurchaseOrdersClient PurchaseOrders { get; }

    public RegenerateKeyClient RegenerateKey { get; }

    public SyncStatusClient SyncStatus { get; }

    public ForceResyncClient ForceResync { get; }

    public TaxRatesClient TaxRates { get; }

    public TrackingCategoriesClient TrackingCategories { get; }

    public TransactionsClient Transactions { get; }

    public VendorCreditsClient VendorCredits { get; }

    public WebhookReceiversClient WebhookReceivers { get; }
}
