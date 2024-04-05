using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum EmploymentsListRequestOrderBy
{
    [EnumMember(Value = "-effective_date")]
    EffectiveDateDescending,

    [EnumMember(Value = "effective_date")]
    EffectiveDateAscending
}
