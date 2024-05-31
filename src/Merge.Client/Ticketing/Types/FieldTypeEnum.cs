using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Ticketing;

#nullable enable

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(StringEnumSerializer<FieldTypeEnum>))]
public enum FieldTypeEnum
{
    [EnumMember(Value = "string")]
    String,

    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "datetime")]
    Datetime,

    [EnumMember(Value = "bool")]
    Bool,

    [EnumMember(Value = "list")]
    List
}
