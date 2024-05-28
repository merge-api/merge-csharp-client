using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Hris;

public enum GenderEnum
{
    [EnumMember(Value = "MALE")]
    Male,

    [EnumMember(Value = "FEMALE")]
    Female,

    [EnumMember(Value = "NON-BINARY")]
    NonBinary,

    [EnumMember(Value = "OTHER")]
    Other,

    [EnumMember(Value = "PREFER_NOT_TO_DISCLOSE")]
    PreferNotToDisclose
}
