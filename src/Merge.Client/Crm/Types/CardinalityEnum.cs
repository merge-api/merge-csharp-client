using System.Runtime.Serialization;

namespace Merge.Client.Crm;

public enum CardinalityEnum
{
    [EnumMember(Value = "ONE_TO_ONE")]
    OneToOne,

    [EnumMember(Value = "MANY_TO_ONE")]
    ManyToOne,

    [EnumMember(Value = "MANY_TO_MANY")]
    ManyToMany,

    [EnumMember(Value = "ONE_TO_MANY")]
    OneToMany
}
