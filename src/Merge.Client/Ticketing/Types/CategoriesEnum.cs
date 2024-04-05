using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Ticketing;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum CategoriesEnum
{
    [EnumMember(Value = "hris")]
    Hris,

    [EnumMember(Value = "ats")]
    Ats,

    [EnumMember(Value = "accounting")]
    Accounting,

    [EnumMember(Value = "ticketing")]
    Ticketing,

    [EnumMember(Value = "crm")]
    Crm,

    [EnumMember(Value = "mktg")]
    Mktg,

    [EnumMember(Value = "filestorage")]
    Filestorage
}
