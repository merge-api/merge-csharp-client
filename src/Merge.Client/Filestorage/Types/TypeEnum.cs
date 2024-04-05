using System.Runtime.Serialization;

namespace Merge.Client.Filestorage;

public enum TypeEnum
{
    [EnumMember(Value = "USER")]
    User,

    [EnumMember(Value = "GROUP")]
    Group,

    [EnumMember(Value = "COMPANY")]
    Company,

    [EnumMember(Value = "ANYONE")]
    Anyone
}
