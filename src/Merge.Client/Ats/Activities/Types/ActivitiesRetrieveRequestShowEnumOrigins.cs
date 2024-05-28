using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum ActivitiesRetrieveRequestShowEnumOrigins
{
    [EnumMember(Value = "activity_type")]
    ActivityType,

    [EnumMember(Value = "activity_type,visibility")]
    ActivityTypeVisibility,

    [EnumMember(Value = "visibility")]
    Visibility
}
