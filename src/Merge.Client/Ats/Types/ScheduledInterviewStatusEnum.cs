using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ats;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum ScheduledInterviewStatusEnum
{
    [EnumMember(Value = "SCHEDULED")]
    Scheduled,

    [EnumMember(Value = "AWAITING_FEEDBACK")]
    AwaitingFeedback,

    [EnumMember(Value = "COMPLETE")]
    Complete
}
