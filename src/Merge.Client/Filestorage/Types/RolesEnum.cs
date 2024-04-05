using System.Runtime.Serialization;

namespace Merge.Client.Filestorage;

public enum RolesEnum
{
    [EnumMember(Value = "READ")]
    Read,

    [EnumMember(Value = "WRITE")]
    Write,

    [EnumMember(Value = "OWNER")]
    Owner
}
