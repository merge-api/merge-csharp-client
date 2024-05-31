using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Ats;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Ats;

[JsonConverter(typeof(StringEnumSerializer<CategoryEnum>))]
public enum CategoryEnum
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
