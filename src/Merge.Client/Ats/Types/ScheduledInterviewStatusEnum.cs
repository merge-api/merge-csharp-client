using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ScheduledInterviewStatusEnum>))]
public enum ScheduledInterviewStatusEnum
{
    [EnumMember(Value = "SCHEDULED")]
    Scheduled,

    [EnumMember(Value = "AWAITING_FEEDBACK")]
    AwaitingFeedback,

    [EnumMember(Value = "COMPLETE")]
    Complete,
}
