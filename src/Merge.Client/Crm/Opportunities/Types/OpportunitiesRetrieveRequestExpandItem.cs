using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<OpportunitiesRetrieveRequestExpandItem>))]
public enum OpportunitiesRetrieveRequestExpandItem
{
    [EnumMember(Value = "account")]
    Account,

    [EnumMember(Value = "owner")]
    Owner,

    [EnumMember(Value = "stage")]
    Stage,
}
