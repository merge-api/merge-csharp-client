using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Hris;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum EmploymentsListRequestOrderBy
{
    [EnumMember(Value = "-effective_date")]
    EffectiveDateDescending,

    [EnumMember(Value = "effective_date")]
    EffectiveDateAscending
}
