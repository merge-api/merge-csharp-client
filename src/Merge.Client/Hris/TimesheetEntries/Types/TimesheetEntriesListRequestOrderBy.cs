using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<TimesheetEntriesListRequestOrderBy>))]
public enum TimesheetEntriesListRequestOrderBy
{
    [EnumMember(Value = "-start_time")]
    StartTimeDescending,

    [EnumMember(Value = "start_time")]
    StartTimeAscending
}
