using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<ActivitiesListRequestShowEnumOrigins>))]
public enum ActivitiesListRequestShowEnumOrigins
{
    [EnumMember(Value = "activity_type")]
    ActivityType,

    [EnumMember(Value = "activity_type,visibility")]
    ActivityTypeVisibility,

    [EnumMember(Value = "visibility")]
    Visibility,
}
