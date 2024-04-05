using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum ScheduledInterviewStatusEnum
{
    [EnumMember(Value = "SCHEDULED")]
    Scheduled,

    [EnumMember(Value = "AWAITING_FEEDBACK")]
    AwaitingFeedback,

    [EnumMember(Value = "COMPLETE")]
    Complete
}
