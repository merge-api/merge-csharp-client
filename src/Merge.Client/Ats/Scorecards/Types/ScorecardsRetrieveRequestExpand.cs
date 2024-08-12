using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ScorecardsRetrieveRequestExpand>))]
public enum ScorecardsRetrieveRequestExpand
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
