using System.Runtime.Serialization;

namespace Merge.Client.Ticketing;

public enum EnabledActionsEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write
}
