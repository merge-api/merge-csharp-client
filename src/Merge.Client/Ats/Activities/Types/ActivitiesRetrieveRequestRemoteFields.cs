using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum ActivitiesRetrieveRequestRemoteFields
{
    [EnumMember(Value = "activity_type")]
    ActivityType,

    [EnumMember(Value = "activity_type,visibility")]
    ActivityTypeVisibility,

    [EnumMember(Value = "visibility")]
    Visibility
}
