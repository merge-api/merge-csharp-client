using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<ApplicationsRetrieveRequestExpandItem>))]
public enum ApplicationsRetrieveRequestExpandItem
{
    [EnumMember(Value = "candidate")]
    Candidate,

    [EnumMember(Value = "credited_to")]
    CreditedTo,

    [EnumMember(Value = "current_stage")]
    CurrentStage,

    [EnumMember(Value = "job")]
    Job,

    [EnumMember(Value = "offers")]
    Offers,

    [EnumMember(Value = "reject_reason")]
    RejectReason,

    [EnumMember(Value = "screening_question_answers")]
    ScreeningQuestionAnswers,

    [EnumMember(Value = "screening_question_answers.question")]
    ScreeningQuestionAnswersQuestion,
}
