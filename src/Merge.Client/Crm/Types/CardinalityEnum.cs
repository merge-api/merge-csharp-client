using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<CardinalityEnum>))]
public enum CardinalityEnum
{
    [EnumMember(Value = "ONE_TO_ONE")]
    OneToOne,

    [EnumMember(Value = "MANY_TO_ONE")]
    ManyToOne,

    [EnumMember(Value = "MANY_TO_MANY")]
    ManyToMany,

    [EnumMember(Value = "ONE_TO_MANY")]
    OneToMany,
}
