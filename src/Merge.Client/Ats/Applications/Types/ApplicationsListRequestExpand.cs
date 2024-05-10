using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum ApplicationsListRequestExpand
{
    [EnumMember(Value = "candidate")]
    Candidate,

    [EnumMember(Value = "candidate,credited_to")]
    CandidateCreditedTo,

    [EnumMember(Value = "candidate,credited_to,current_stage")]
    CandidateCreditedToCurrentStage,

    [EnumMember(Value = "candidate,credited_to,current_stage,reject_reason")]
    CandidateCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "candidate,credited_to,reject_reason")]
    CandidateCreditedToRejectReason,

    [EnumMember(Value = "candidate,current_stage")]
    CandidateCurrentStage,

    [EnumMember(Value = "candidate,current_stage,reject_reason")]
    CandidateCurrentStageRejectReason,

    [EnumMember(Value = "candidate,job")]
    CandidateJob,

    [EnumMember(Value = "candidate,job,credited_to")]
    CandidateJobCreditedTo,

    [EnumMember(Value = "candidate,job,credited_to,current_stage")]
    CandidateJobCreditedToCurrentStage,

    [EnumMember(Value = "candidate,job,credited_to,current_stage,reject_reason")]
    CandidateJobCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "candidate,job,credited_to,reject_reason")]
    CandidateJobCreditedToRejectReason,

    [EnumMember(Value = "candidate,job,current_stage")]
    CandidateJobCurrentStage,

    [EnumMember(Value = "candidate,job,current_stage,reject_reason")]
    CandidateJobCurrentStageRejectReason,

    [EnumMember(Value = "candidate,job,reject_reason")]
    CandidateJobRejectReason,

    [EnumMember(Value = "candidate,reject_reason")]
    CandidateRejectReason,

    [EnumMember(Value = "credited_to")]
    CreditedTo,

    [EnumMember(Value = "credited_to,current_stage")]
    CreditedToCurrentStage,

    [EnumMember(Value = "credited_to,current_stage,reject_reason")]
    CreditedToCurrentStageRejectReason,

    [EnumMember(Value = "credited_to,reject_reason")]
    CreditedToRejectReason,

    [EnumMember(Value = "current_stage")]
    CurrentStage,

    [EnumMember(Value = "current_stage,reject_reason")]
    CurrentStageRejectReason,

    [EnumMember(Value = "job")]
    Job,

    [EnumMember(Value = "job,credited_to")]
    JobCreditedTo,

    [EnumMember(Value = "job,credited_to,current_stage")]
    JobCreditedToCurrentStage,

    [EnumMember(Value = "job,credited_to,current_stage,reject_reason")]
    JobCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "job,credited_to,reject_reason")]
    JobCreditedToRejectReason,

    [EnumMember(Value = "job,current_stage")]
    JobCurrentStage,

    [EnumMember(Value = "job,current_stage,reject_reason")]
    JobCurrentStageRejectReason,

    [EnumMember(Value = "job,reject_reason")]
    JobRejectReason,

    [EnumMember(Value = "offers")]
    Offers,

    [EnumMember(Value = "offers,candidate")]
    OffersCandidate,

    [EnumMember(Value = "offers,candidate,credited_to")]
    OffersCandidateCreditedTo,

    [EnumMember(Value = "offers,candidate,credited_to,current_stage")]
    OffersCandidateCreditedToCurrentStage,

    [EnumMember(Value = "offers,candidate,credited_to,current_stage,reject_reason")]
    OffersCandidateCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "offers,candidate,credited_to,reject_reason")]
    OffersCandidateCreditedToRejectReason,

    [EnumMember(Value = "offers,candidate,current_stage")]
    OffersCandidateCurrentStage,

    [EnumMember(Value = "offers,candidate,current_stage,reject_reason")]
    OffersCandidateCurrentStageRejectReason,

    [EnumMember(Value = "offers,candidate,job")]
    OffersCandidateJob,

    [EnumMember(Value = "offers,candidate,job,credited_to")]
    OffersCandidateJobCreditedTo,

    [EnumMember(Value = "offers,candidate,job,credited_to,current_stage")]
    OffersCandidateJobCreditedToCurrentStage,

    [EnumMember(Value = "offers,candidate,job,credited_to,current_stage,reject_reason")]
    OffersCandidateJobCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "offers,candidate,job,credited_to,reject_reason")]
    OffersCandidateJobCreditedToRejectReason,

    [EnumMember(Value = "offers,candidate,job,current_stage")]
    OffersCandidateJobCurrentStage,

    [EnumMember(Value = "offers,candidate,job,current_stage,reject_reason")]
    OffersCandidateJobCurrentStageRejectReason,

    [EnumMember(Value = "offers,candidate,job,reject_reason")]
    OffersCandidateJobRejectReason,

    [EnumMember(Value = "offers,candidate,reject_reason")]
    OffersCandidateRejectReason,

    [EnumMember(Value = "offers,credited_to")]
    OffersCreditedTo,

    [EnumMember(Value = "offers,credited_to,current_stage")]
    OffersCreditedToCurrentStage,

    [EnumMember(Value = "offers,credited_to,current_stage,reject_reason")]
    OffersCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "offers,credited_to,reject_reason")]
    OffersCreditedToRejectReason,

    [EnumMember(Value = "offers,current_stage")]
    OffersCurrentStage,

    [EnumMember(Value = "offers,current_stage,reject_reason")]
    OffersCurrentStageRejectReason,

    [EnumMember(Value = "offers,job")]
    OffersJob,

    [EnumMember(Value = "offers,job,credited_to")]
    OffersJobCreditedTo,

    [EnumMember(Value = "offers,job,credited_to,current_stage")]
    OffersJobCreditedToCurrentStage,

    [EnumMember(Value = "offers,job,credited_to,current_stage,reject_reason")]
    OffersJobCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "offers,job,credited_to,reject_reason")]
    OffersJobCreditedToRejectReason,

    [EnumMember(Value = "offers,job,current_stage")]
    OffersJobCurrentStage,

    [EnumMember(Value = "offers,job,current_stage,reject_reason")]
    OffersJobCurrentStageRejectReason,

    [EnumMember(Value = "offers,job,reject_reason")]
    OffersJobRejectReason,

    [EnumMember(Value = "offers,reject_reason")]
    OffersRejectReason,

    [EnumMember(Value = "reject_reason")]
    RejectReason
}
