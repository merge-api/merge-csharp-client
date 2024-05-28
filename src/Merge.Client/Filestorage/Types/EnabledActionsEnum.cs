using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Filestorage;

public enum EnabledActionsEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write
}
