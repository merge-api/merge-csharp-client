using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<FieldFormatEnum>))]
public enum FieldFormatEnum
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
