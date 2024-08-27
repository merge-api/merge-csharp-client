using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ApplicationsListRequestExpand>))]
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

    [EnumMember(Value = "offers,screening_question_answers")]
    OffersScreeningQuestionAnswers,

    [EnumMember(Value = "offers,screening_question_answers,candidate")]
    OffersScreeningQuestionAnswersCandidate,

    [EnumMember(Value = "offers,screening_question_answers,candidate,credited_to")]
    OffersScreeningQuestionAnswersCandidateCreditedTo,

    [EnumMember(Value = "offers,screening_question_answers,candidate,credited_to,current_stage")]
    OffersScreeningQuestionAnswersCandidateCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,candidate,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersCandidateCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,candidate,credited_to,reject_reason")]
    OffersScreeningQuestionAnswersCandidateCreditedToRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,candidate,current_stage")]
    OffersScreeningQuestionAnswersCandidateCurrentStage,

    [EnumMember(Value = "offers,screening_question_answers,candidate,current_stage,reject_reason")]
    OffersScreeningQuestionAnswersCandidateCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,candidate,job")]
    OffersScreeningQuestionAnswersCandidateJob,

    [EnumMember(Value = "offers,screening_question_answers,candidate,job,credited_to")]
    OffersScreeningQuestionAnswersCandidateJobCreditedTo,

    [EnumMember(
        Value = "offers,screening_question_answers,candidate,job,credited_to,current_stage"
    )]
    OffersScreeningQuestionAnswersCandidateJobCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,candidate,job,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersCandidateJobCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,candidate,job,credited_to,reject_reason"
    )]
    OffersScreeningQuestionAnswersCandidateJobCreditedToRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,candidate,job,current_stage")]
    OffersScreeningQuestionAnswersCandidateJobCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,candidate,job,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersCandidateJobCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,candidate,job,reject_reason")]
    OffersScreeningQuestionAnswersCandidateJobRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,candidate,reject_reason")]
    OffersScreeningQuestionAnswersCandidateRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,credited_to")]
    OffersScreeningQuestionAnswersCreditedTo,

    [EnumMember(Value = "offers,screening_question_answers,credited_to,current_stage")]
    OffersScreeningQuestionAnswersCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,credited_to,reject_reason")]
    OffersScreeningQuestionAnswersCreditedToRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,current_stage")]
    OffersScreeningQuestionAnswersCurrentStage,

    [EnumMember(Value = "offers,screening_question_answers,current_stage,reject_reason")]
    OffersScreeningQuestionAnswersCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,job")]
    OffersScreeningQuestionAnswersJob,

    [EnumMember(Value = "offers,screening_question_answers,job,credited_to")]
    OffersScreeningQuestionAnswersJobCreditedTo,

    [EnumMember(Value = "offers,screening_question_answers,job,credited_to,current_stage")]
    OffersScreeningQuestionAnswersJobCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,job,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersJobCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,job,credited_to,reject_reason")]
    OffersScreeningQuestionAnswersJobCreditedToRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,job,current_stage")]
    OffersScreeningQuestionAnswersJobCurrentStage,

    [EnumMember(Value = "offers,screening_question_answers,job,current_stage,reject_reason")]
    OffersScreeningQuestionAnswersJobCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,job,reject_reason")]
    OffersScreeningQuestionAnswersJobRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,reject_reason")]
    OffersScreeningQuestionAnswersRejectReason,

    [EnumMember(Value = "offers,screening_question_answers,screening_question_answers.question")]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestion,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidate,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,credited_to"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCreditedTo,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,credited_to,current_stage"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,credited_to,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCreditedToRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,current_stage"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,job"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJob,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,job,credited_to"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCreditedTo,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,job,credited_to,current_stage"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,job,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,job,credited_to,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCreditedToRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,job,current_stage"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,job,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,job,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,candidate,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,credited_to"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCreditedTo,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,credited_to,current_stage"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,credited_to,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCreditedToRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,current_stage"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,job"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionJob,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,job,credited_to"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCreditedTo,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,job,credited_to,current_stage"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,job,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,job,credited_to,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCreditedToRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,job,current_stage"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,job,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,job,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers,screening_question_answers.question,reject_reason"
    )]
    OffersScreeningQuestionAnswersScreeningQuestionAnswersQuestionRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question")]
    OffersScreeningQuestionAnswersQuestion,

    [EnumMember(Value = "offers,screening_question_answers.question,candidate")]
    OffersScreeningQuestionAnswersQuestionCandidate,

    [EnumMember(Value = "offers,screening_question_answers.question,candidate,credited_to")]
    OffersScreeningQuestionAnswersQuestionCandidateCreditedTo,

    [EnumMember(
        Value = "offers,screening_question_answers.question,candidate,credited_to,current_stage"
    )]
    OffersScreeningQuestionAnswersQuestionCandidateCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers.question,candidate,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersQuestionCandidateCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers.question,candidate,credited_to,reject_reason"
    )]
    OffersScreeningQuestionAnswersQuestionCandidateCreditedToRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,candidate,current_stage")]
    OffersScreeningQuestionAnswersQuestionCandidateCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers.question,candidate,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersQuestionCandidateCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,candidate,job")]
    OffersScreeningQuestionAnswersQuestionCandidateJob,

    [EnumMember(Value = "offers,screening_question_answers.question,candidate,job,credited_to")]
    OffersScreeningQuestionAnswersQuestionCandidateJobCreditedTo,

    [EnumMember(
        Value = "offers,screening_question_answers.question,candidate,job,credited_to,current_stage"
    )]
    OffersScreeningQuestionAnswersQuestionCandidateJobCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers.question,candidate,job,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersQuestionCandidateJobCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "offers,screening_question_answers.question,candidate,job,credited_to,reject_reason"
    )]
    OffersScreeningQuestionAnswersQuestionCandidateJobCreditedToRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,candidate,job,current_stage")]
    OffersScreeningQuestionAnswersQuestionCandidateJobCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers.question,candidate,job,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersQuestionCandidateJobCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,candidate,job,reject_reason")]
    OffersScreeningQuestionAnswersQuestionCandidateJobRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,candidate,reject_reason")]
    OffersScreeningQuestionAnswersQuestionCandidateRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,credited_to")]
    OffersScreeningQuestionAnswersQuestionCreditedTo,

    [EnumMember(Value = "offers,screening_question_answers.question,credited_to,current_stage")]
    OffersScreeningQuestionAnswersQuestionCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers.question,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersQuestionCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,credited_to,reject_reason")]
    OffersScreeningQuestionAnswersQuestionCreditedToRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,current_stage")]
    OffersScreeningQuestionAnswersQuestionCurrentStage,

    [EnumMember(Value = "offers,screening_question_answers.question,current_stage,reject_reason")]
    OffersScreeningQuestionAnswersQuestionCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,job")]
    OffersScreeningQuestionAnswersQuestionJob,

    [EnumMember(Value = "offers,screening_question_answers.question,job,credited_to")]
    OffersScreeningQuestionAnswersQuestionJobCreditedTo,

    [EnumMember(Value = "offers,screening_question_answers.question,job,credited_to,current_stage")]
    OffersScreeningQuestionAnswersQuestionJobCreditedToCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers.question,job,credited_to,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersQuestionJobCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,job,credited_to,reject_reason")]
    OffersScreeningQuestionAnswersQuestionJobCreditedToRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,job,current_stage")]
    OffersScreeningQuestionAnswersQuestionJobCurrentStage,

    [EnumMember(
        Value = "offers,screening_question_answers.question,job,current_stage,reject_reason"
    )]
    OffersScreeningQuestionAnswersQuestionJobCurrentStageRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,job,reject_reason")]
    OffersScreeningQuestionAnswersQuestionJobRejectReason,

    [EnumMember(Value = "offers,screening_question_answers.question,reject_reason")]
    OffersScreeningQuestionAnswersQuestionRejectReason,

    [EnumMember(Value = "reject_reason")]
    RejectReason,

    [EnumMember(Value = "screening_question_answers")]
    ScreeningQuestionAnswers,

    [EnumMember(Value = "screening_question_answers,candidate")]
    ScreeningQuestionAnswersCandidate,

    [EnumMember(Value = "screening_question_answers,candidate,credited_to")]
    ScreeningQuestionAnswersCandidateCreditedTo,

    [EnumMember(Value = "screening_question_answers,candidate,credited_to,current_stage")]
    ScreeningQuestionAnswersCandidateCreditedToCurrentStage,

    [EnumMember(
        Value = "screening_question_answers,candidate,credited_to,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersCandidateCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers,candidate,credited_to,reject_reason")]
    ScreeningQuestionAnswersCandidateCreditedToRejectReason,

    [EnumMember(Value = "screening_question_answers,candidate,current_stage")]
    ScreeningQuestionAnswersCandidateCurrentStage,

    [EnumMember(Value = "screening_question_answers,candidate,current_stage,reject_reason")]
    ScreeningQuestionAnswersCandidateCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers,candidate,job")]
    ScreeningQuestionAnswersCandidateJob,

    [EnumMember(Value = "screening_question_answers,candidate,job,credited_to")]
    ScreeningQuestionAnswersCandidateJobCreditedTo,

    [EnumMember(Value = "screening_question_answers,candidate,job,credited_to,current_stage")]
    ScreeningQuestionAnswersCandidateJobCreditedToCurrentStage,

    [EnumMember(
        Value = "screening_question_answers,candidate,job,credited_to,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersCandidateJobCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers,candidate,job,credited_to,reject_reason")]
    ScreeningQuestionAnswersCandidateJobCreditedToRejectReason,

    [EnumMember(Value = "screening_question_answers,candidate,job,current_stage")]
    ScreeningQuestionAnswersCandidateJobCurrentStage,

    [EnumMember(Value = "screening_question_answers,candidate,job,current_stage,reject_reason")]
    ScreeningQuestionAnswersCandidateJobCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers,candidate,job,reject_reason")]
    ScreeningQuestionAnswersCandidateJobRejectReason,

    [EnumMember(Value = "screening_question_answers,candidate,reject_reason")]
    ScreeningQuestionAnswersCandidateRejectReason,

    [EnumMember(Value = "screening_question_answers,credited_to")]
    ScreeningQuestionAnswersCreditedTo,

    [EnumMember(Value = "screening_question_answers,credited_to,current_stage")]
    ScreeningQuestionAnswersCreditedToCurrentStage,

    [EnumMember(Value = "screening_question_answers,credited_to,current_stage,reject_reason")]
    ScreeningQuestionAnswersCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers,credited_to,reject_reason")]
    ScreeningQuestionAnswersCreditedToRejectReason,

    [EnumMember(Value = "screening_question_answers,current_stage")]
    ScreeningQuestionAnswersCurrentStage,

    [EnumMember(Value = "screening_question_answers,current_stage,reject_reason")]
    ScreeningQuestionAnswersCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers,job")]
    ScreeningQuestionAnswersJob,

    [EnumMember(Value = "screening_question_answers,job,credited_to")]
    ScreeningQuestionAnswersJobCreditedTo,

    [EnumMember(Value = "screening_question_answers,job,credited_to,current_stage")]
    ScreeningQuestionAnswersJobCreditedToCurrentStage,

    [EnumMember(Value = "screening_question_answers,job,credited_to,current_stage,reject_reason")]
    ScreeningQuestionAnswersJobCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers,job,credited_to,reject_reason")]
    ScreeningQuestionAnswersJobCreditedToRejectReason,

    [EnumMember(Value = "screening_question_answers,job,current_stage")]
    ScreeningQuestionAnswersJobCurrentStage,

    [EnumMember(Value = "screening_question_answers,job,current_stage,reject_reason")]
    ScreeningQuestionAnswersJobCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers,job,reject_reason")]
    ScreeningQuestionAnswersJobRejectReason,

    [EnumMember(Value = "screening_question_answers,reject_reason")]
    ScreeningQuestionAnswersRejectReason,

    [EnumMember(Value = "screening_question_answers,screening_question_answers.question")]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestion,

    [EnumMember(Value = "screening_question_answers,screening_question_answers.question,candidate")]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidate,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,credited_to"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCreditedTo,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,credited_to,current_stage"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCreditedToCurrentStage,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,credited_to,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,credited_to,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCreditedToRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,current_stage"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCurrentStage,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateCurrentStageRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,job"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJob,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,job,credited_to"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCreditedTo,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,job,credited_to,current_stage"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCreditedToCurrentStage,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,job,credited_to,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,job,credited_to,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCreditedToRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,job,current_stage"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCurrentStage,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,job,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobCurrentStageRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,job,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateJobRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,candidate,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCandidateRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,credited_to"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCreditedTo,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,credited_to,current_stage"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCreditedToCurrentStage,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,credited_to,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,credited_to,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCreditedToRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,current_stage"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCurrentStage,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers,screening_question_answers.question,job")]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionJob,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,job,credited_to"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCreditedTo,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,job,credited_to,current_stage"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCreditedToCurrentStage,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,job,credited_to,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,job,credited_to,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCreditedToRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,job,current_stage"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCurrentStage,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,job,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobCurrentStageRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,job,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionJobRejectReason,

    [EnumMember(
        Value = "screening_question_answers,screening_question_answers.question,reject_reason"
    )]
    ScreeningQuestionAnswersScreeningQuestionAnswersQuestionRejectReason,

    [EnumMember(Value = "screening_question_answers.question")]
    ScreeningQuestionAnswersQuestion,

    [EnumMember(Value = "screening_question_answers.question,candidate")]
    ScreeningQuestionAnswersQuestionCandidate,

    [EnumMember(Value = "screening_question_answers.question,candidate,credited_to")]
    ScreeningQuestionAnswersQuestionCandidateCreditedTo,

    [EnumMember(Value = "screening_question_answers.question,candidate,credited_to,current_stage")]
    ScreeningQuestionAnswersQuestionCandidateCreditedToCurrentStage,

    [EnumMember(
        Value = "screening_question_answers.question,candidate,credited_to,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersQuestionCandidateCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers.question,candidate,credited_to,reject_reason")]
    ScreeningQuestionAnswersQuestionCandidateCreditedToRejectReason,

    [EnumMember(Value = "screening_question_answers.question,candidate,current_stage")]
    ScreeningQuestionAnswersQuestionCandidateCurrentStage,

    [EnumMember(
        Value = "screening_question_answers.question,candidate,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersQuestionCandidateCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers.question,candidate,job")]
    ScreeningQuestionAnswersQuestionCandidateJob,

    [EnumMember(Value = "screening_question_answers.question,candidate,job,credited_to")]
    ScreeningQuestionAnswersQuestionCandidateJobCreditedTo,

    [EnumMember(
        Value = "screening_question_answers.question,candidate,job,credited_to,current_stage"
    )]
    ScreeningQuestionAnswersQuestionCandidateJobCreditedToCurrentStage,

    [EnumMember(
        Value = "screening_question_answers.question,candidate,job,credited_to,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersQuestionCandidateJobCreditedToCurrentStageRejectReason,

    [EnumMember(
        Value = "screening_question_answers.question,candidate,job,credited_to,reject_reason"
    )]
    ScreeningQuestionAnswersQuestionCandidateJobCreditedToRejectReason,

    [EnumMember(Value = "screening_question_answers.question,candidate,job,current_stage")]
    ScreeningQuestionAnswersQuestionCandidateJobCurrentStage,

    [EnumMember(
        Value = "screening_question_answers.question,candidate,job,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersQuestionCandidateJobCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers.question,candidate,job,reject_reason")]
    ScreeningQuestionAnswersQuestionCandidateJobRejectReason,

    [EnumMember(Value = "screening_question_answers.question,candidate,reject_reason")]
    ScreeningQuestionAnswersQuestionCandidateRejectReason,

    [EnumMember(Value = "screening_question_answers.question,credited_to")]
    ScreeningQuestionAnswersQuestionCreditedTo,

    [EnumMember(Value = "screening_question_answers.question,credited_to,current_stage")]
    ScreeningQuestionAnswersQuestionCreditedToCurrentStage,

    [EnumMember(
        Value = "screening_question_answers.question,credited_to,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersQuestionCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers.question,credited_to,reject_reason")]
    ScreeningQuestionAnswersQuestionCreditedToRejectReason,

    [EnumMember(Value = "screening_question_answers.question,current_stage")]
    ScreeningQuestionAnswersQuestionCurrentStage,

    [EnumMember(Value = "screening_question_answers.question,current_stage,reject_reason")]
    ScreeningQuestionAnswersQuestionCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers.question,job")]
    ScreeningQuestionAnswersQuestionJob,

    [EnumMember(Value = "screening_question_answers.question,job,credited_to")]
    ScreeningQuestionAnswersQuestionJobCreditedTo,

    [EnumMember(Value = "screening_question_answers.question,job,credited_to,current_stage")]
    ScreeningQuestionAnswersQuestionJobCreditedToCurrentStage,

    [EnumMember(
        Value = "screening_question_answers.question,job,credited_to,current_stage,reject_reason"
    )]
    ScreeningQuestionAnswersQuestionJobCreditedToCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers.question,job,credited_to,reject_reason")]
    ScreeningQuestionAnswersQuestionJobCreditedToRejectReason,

    [EnumMember(Value = "screening_question_answers.question,job,current_stage")]
    ScreeningQuestionAnswersQuestionJobCurrentStage,

    [EnumMember(Value = "screening_question_answers.question,job,current_stage,reject_reason")]
    ScreeningQuestionAnswersQuestionJobCurrentStageRejectReason,

    [EnumMember(Value = "screening_question_answers.question,job,reject_reason")]
    ScreeningQuestionAnswersQuestionJobRejectReason,

    [EnumMember(Value = "screening_question_answers.question,reject_reason")]
    ScreeningQuestionAnswersQuestionRejectReason,
}
