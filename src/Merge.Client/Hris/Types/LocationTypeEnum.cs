using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum LocationTypeEnum
{
    [EnumMember(Value = "HOME")]
    Home,

    [EnumMember(Value = "WORK")]
    Work
}
