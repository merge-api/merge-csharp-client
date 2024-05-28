using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum TimesheetEntriesListRequestOrderBy
{
    [EnumMember(Value = "-start_time")]
    StartTimeDescending,

    [EnumMember(Value = "start_time")]
    StartTimeAscending
}
