using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<InterviewsListRequestExpand>))]
public enum InterviewsListRequestExpand
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "application,job_interview_stage")]
    ApplicationJobInterviewStage,

    [EnumMember(Value = "interviewers")]
    Interviewers,

    [EnumMember(Value = "interviewers,application")]
    InterviewersApplication,

    [EnumMember(Value = "interviewers,application,job_interview_stage")]
    InterviewersApplicationJobInterviewStage,

    [EnumMember(Value = "interviewers,job_interview_stage")]
    InterviewersJobInterviewStage,

    [EnumMember(Value = "interviewers,organizer")]
    InterviewersOrganizer,

    [EnumMember(Value = "interviewers,organizer,application")]
    InterviewersOrganizerApplication,

    [EnumMember(Value = "interviewers,organizer,application,job_interview_stage")]
    InterviewersOrganizerApplicationJobInterviewStage,

    [EnumMember(Value = "interviewers,organizer,job_interview_stage")]
    InterviewersOrganizerJobInterviewStage,

    [EnumMember(Value = "job_interview_stage")]
    JobInterviewStage,

    [EnumMember(Value = "organizer")]
    Organizer,

    [EnumMember(Value = "organizer,application")]
    OrganizerApplication,

    [EnumMember(Value = "organizer,application,job_interview_stage")]
    OrganizerApplicationJobInterviewStage,

    [EnumMember(Value = "organizer,job_interview_stage")]
    OrganizerJobInterviewStage,
}
