using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;
using Merge.Client.Crm;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<LinkedAccountsListRequestCategory>))]
public enum LinkedAccountsListRequestCategory
{
    [EnumMember(Value = "accounting")]
    Accounting,

    [EnumMember(Value = "ats")]
    Ats,

    [EnumMember(Value = "crm")]
    Crm,

    [EnumMember(Value = "filestorage")]
    Filestorage,

    [EnumMember(Value = "hris")]
    Hris,

    [EnumMember(Value = "mktg")]
    Mktg,

    [EnumMember(Value = "ticketing")]
    Ticketing
}
