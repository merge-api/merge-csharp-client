using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<TimesheetEntriesListRequestOrderBy>))]
public enum TimesheetEntriesListRequestOrderBy
{
    [EnumMember(Value = "-start_time")]
    StartTimeDescending,

    [EnumMember(Value = "start_time")]
    StartTimeAscending,
}
