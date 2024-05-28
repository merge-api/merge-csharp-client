using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Ats;

public enum EnabledActionsEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write
}
