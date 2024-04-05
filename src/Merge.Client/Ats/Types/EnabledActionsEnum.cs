using System.Runtime.Serialization;

namespace Merge.Client.Ats;

public enum EnabledActionsEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write
}
