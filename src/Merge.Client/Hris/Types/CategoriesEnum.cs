using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Hris;

#nullable enable

namespace Merge.Client.Hris;

[JsonConverter(typeof(StringEnumSerializer<CategoriesEnum>))]
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
