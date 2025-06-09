using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.FileStorage;

[JsonConverter(typeof(EnumSerializer<CategoryEnum>))]
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
    Filestorage,
}
