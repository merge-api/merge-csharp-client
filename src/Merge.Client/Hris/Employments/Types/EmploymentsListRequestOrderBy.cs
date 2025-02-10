using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Hris;

[JsonConverter(typeof(EnumSerializer<EmploymentsListRequestOrderBy>))]
public enum EmploymentsListRequestOrderBy
{
    [EnumMember(Value = "-effective_date")]
    EffectiveDateDescending,

    [EnumMember(Value = "effective_date")]
    EffectiveDateAscending,
}
