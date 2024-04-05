using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Crm;

[JsonConverter(typeof(TolerantEnumConverter))]
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
