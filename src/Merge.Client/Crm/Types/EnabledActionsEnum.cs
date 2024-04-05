using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum EnabledActionsEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write
}
