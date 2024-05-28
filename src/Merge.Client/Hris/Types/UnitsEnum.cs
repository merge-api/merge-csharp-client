using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum UnitsEnum
{
    [EnumMember(Value = "HOURS")]
    Hours,

    [EnumMember(Value = "DAYS")]
    Days
}
