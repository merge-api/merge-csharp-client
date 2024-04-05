using System.Runtime.Serialization;

namespace Merge.Client.Filestorage;

public enum EnabledActionsEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write
}
