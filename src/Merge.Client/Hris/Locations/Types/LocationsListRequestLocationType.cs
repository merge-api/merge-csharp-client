using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum LocationsListRequestLocationType
{
    [EnumMember(Value = "HOME")]
    Home,

    [EnumMember(Value = "WORK")]
    Work
}
