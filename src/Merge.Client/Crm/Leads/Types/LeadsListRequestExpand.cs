using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Crm;

public enum LeadsListRequestExpand
{
    [EnumMember(Value = "converted_account")]
    ConvertedAccount,

    [EnumMember(Value = "converted_contact")]
    ConvertedContact,

    [EnumMember(Value = "converted_contact,converted_account")]
    ConvertedContactConvertedAccount,

    [EnumMember(Value = "owner")]
    Owner,

    [EnumMember(Value = "owner,converted_account")]
    OwnerConvertedAccount,

    [EnumMember(Value = "owner,converted_contact")]
    OwnerConvertedContact,

    [EnumMember(Value = "owner,converted_contact,converted_account")]
    OwnerConvertedContactConvertedAccount
}
