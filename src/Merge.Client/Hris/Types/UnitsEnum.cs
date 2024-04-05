using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum UnitsEnum
{
    [EnumMember(Value = "HOURS")]
    Hours,

    [EnumMember(Value = "DAYS")]
    Days
}
