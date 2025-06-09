using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<InterviewsRetrieveRequestExpandItem>))]
public enum InterviewsRetrieveRequestExpandItem
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "interviewers")]
    Interviewers,

    [EnumMember(Value = "job_interview_stage")]
    JobInterviewStage,

    [EnumMember(Value = "organizer")]
    Organizer,
}
