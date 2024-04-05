using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum TimesheetEntriesListRequestOrderBy
{
    [EnumMember(Value = "-start_time")]
    StartTimeDescending,

    [EnumMember(Value = "start_time")]
    StartTimeAscending
}
