using System.Runtime.Serialization;

namespace Merge.Client.Hris;

public enum EnabledActionsEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write
}
