using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Ats;

[JsonConverter(typeof(EnumSerializer<ScheduledInterviewStatusEnum>))]
public enum ScheduledInterviewStatusEnum
{
    [EnumMember(Value = "SCHEDULED")]
    Scheduled,

    [EnumMember(Value = "AWAITING_FEEDBACK")]
    AwaitingFeedback,

    [EnumMember(Value = "COMPLETE")]
    Complete,
}
