using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum ScorecardsListRequestExpand
{
    [EnumMember(Value = "application")]
    Application,

    [EnumMember(Value = "application,interview")]
    ApplicationInterview,

    [EnumMember(Value = "application,interview,interviewer")]
    ApplicationInterviewInterviewer,

    [EnumMember(Value = "application,interviewer")]
    ApplicationInterviewer,

    [EnumMember(Value = "interview")]
    Interview,

    [EnumMember(Value = "interview,interviewer")]
    InterviewInterviewer,

    [EnumMember(Value = "interviewer")]
    Interviewer
}
