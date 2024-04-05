using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum EnabledActionsEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write
}
