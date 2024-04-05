using System.Runtime.Serialization;

namespace Merge.Client.Crm;

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
