using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Crm;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum EngagementsListRequestExpand
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "account,engagement_type")]
    AccountEngagementType,

    [EnumMember(Value = "contacts")]
    Contacts,

    [EnumMember(Value = "contacts,account")]
    ContactsAccount,

    [EnumMember(Value = "contacts,account,engagement_type")]
    ContactsAccountEngagementType,

    [EnumMember(Value = "contacts,engagement_type")]
    ContactsEngagementType,

    [EnumMember(Value = "contacts,owner")]
    ContactsOwner,

    [EnumMember(Value = "contacts,owner,account")]
    ContactsOwnerAccount,

    [EnumMember(Value = "contacts,owner,account,engagement_type")]
    ContactsOwnerAccountEngagementType,

    [EnumMember(Value = "contacts,owner,engagement_type")]
    ContactsOwnerEngagementType,

    [EnumMember(Value = "engagement_type")]
    EngagementType,

    [EnumMember(Value = "owner")]
    Owner,

    [EnumMember(Value = "owner,account")]
    OwnerAccount,

    [EnumMember(Value = "owner,account,engagement_type")]
    OwnerAccountEngagementType,

    [EnumMember(Value = "owner,engagement_type")]
    OwnerEngagementType
}
