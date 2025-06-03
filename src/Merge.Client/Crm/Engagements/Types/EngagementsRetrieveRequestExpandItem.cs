using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<EngagementsRetrieveRequestExpandItem>))]
public enum EngagementsRetrieveRequestExpandItem
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "contacts")]
    Contacts,

    [EnumMember(Value = "engagement_type")]
    EngagementType,

    [EnumMember(Value = "owner")]
    Owner,
}
