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

    [EnumMember(Value = "reject_reason")]
    RejectReason
}
