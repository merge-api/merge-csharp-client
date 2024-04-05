using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum UnitsEnum
{
    [EnumMember(Value = "HOURS")]
    Hours,

    [EnumMember(Value = "DAYS")]
    Days
}
