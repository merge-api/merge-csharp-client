using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Crm;

[JsonConverter(typeof(TolerantEnumConverter))]
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
