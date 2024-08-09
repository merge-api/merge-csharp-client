using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

public class AtsClient
{
    private RawClient _client;

    public AtsClient(RawClient client)
    {
        _client = client;
        AccountDetails = new AccountDetailsClient(_client);
        AccountToken = new AccountTokenClient(_client);
        Activities = new ActivitiesClient(_client);
        Applications = new ApplicationsClient(_client);
        AsyncPassthrough = new AsyncPassthroughClient(_client);
        Attachments = new AttachmentsClient(_client);
        AuditTrail = new AuditTrailClient(_client);
        AvailableActions = new AvailableActionsClient(_client);
        Candidates = new CandidatesClient(_client);
        Scopes = new ScopesClient(_client);
        DeleteAccount = new DeleteAccountClient(_client);
        Departments = new DepartmentsClient(_client);
        Eeocs = new EeocsClient(_client);
        FieldMapping = new FieldMappingClient(_client);
        GenerateKey = new GenerateKeyClient(_client);
        Interviews = new InterviewsClient(_client);
        Issues = new IssuesClient(_client);
        JobInterviewStages = new JobInterviewStagesClient(_client);
        JobPostings = new JobPostingsClient(_client);
        Jobs = new JobsClient(_client);
        LinkToken = new LinkTokenClient(_client);
        LinkedAccounts = new LinkedAccountsClient(_client);
        Offers = new OffersClient(_client);
        Offices = new OfficesClient(_client);
        Passthrough = new PassthroughClient(_client);
        RegenerateKey = new RegenerateKeyClient(_client);
        RejectReasons = new RejectReasonsClient(_client);
        Scorecards = new ScorecardsClient(_client);
        SyncStatus = new SyncStatusClient(_client);
        ForceResync = new ForceResyncClient(_client);
        Tags = new TagsClient(_client);
        Users = new UsersClient(_client);
        WebhookReceivers = new WebhookReceiversClient(_client);
    }

    public AccountDetailsClient AccountDetails { get; }

    public AccountTokenClient AccountToken { get; }

    public ActivitiesClient Activities { get; }

    public ApplicationsClient Applications { get; }

    public AsyncPassthroughClient AsyncPassthrough { get; }

    public AttachmentsClient Attachments { get; }

    public AuditTrailClient AuditTrail { get; }

    public AvailableActionsClient AvailableActions { get; }

    public CandidatesClient Candidates { get; }

    public ScopesClient Scopes { get; }

    public DeleteAccountClient DeleteAccount { get; }

    public DepartmentsClient Departments { get; }

    public EeocsClient Eeocs { get; }

    public FieldMappingClient FieldMapping { get; }

    public GenerateKeyClient GenerateKey { get; }

    public InterviewsClient Interviews { get; }

    public IssuesClient Issues { get; }

    public JobInterviewStagesClient JobInterviewStages { get; }

    public JobPostingsClient JobPostings { get; }

    public JobsClient Jobs { get; }

    public LinkTokenClient LinkToken { get; }

    public LinkedAccountsClient LinkedAccounts { get; }

    public OffersClient Offers { get; }

    public OfficesClient Offices { get; }

    public PassthroughClient Passthrough { get; }

    public RegenerateKeyClient RegenerateKey { get; }

    public RejectReasonsClient RejectReasons { get; }

    public ScorecardsClient Scorecards { get; }

    public SyncStatusClient SyncStatus { get; }

    public ForceResyncClient ForceResync { get; }

    public TagsClient Tags { get; }

    public UsersClient Users { get; }

    public WebhookReceiversClient WebhookReceivers { get; }
}
