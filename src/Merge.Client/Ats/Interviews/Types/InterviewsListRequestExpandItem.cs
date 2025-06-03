using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<InterviewsListRequestExpandItem>))]
public enum InterviewsListRequestExpandItem
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
