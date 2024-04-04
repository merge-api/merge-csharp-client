using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum TimesheetEntriesListRequestOrderBy
{
    [EnumMember(Value = "-start_time")]
    StartTimeDescending,

    [EnumMember(Value = "start_time")]
    StartTimeAscending
}
