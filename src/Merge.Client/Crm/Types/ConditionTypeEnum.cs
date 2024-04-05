using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Crm;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum ConditionTypeEnum
{
    [EnumMember(Value = "BOOLEAN")]
    Boolean,

    [EnumMember(Value = "DATE")]
    Date,

    [EnumMember(Value = "DATE_TIME")]
    DateTime,

    [EnumMember(Value = "INTEGER")]
    Integer,

    [EnumMember(Value = "FLOAT")]
    Float,

    [EnumMember(Value = "STRING")]
    String,

    [EnumMember(Value = "LIST_OF_STRINGS")]
    ListOfStrings
}
