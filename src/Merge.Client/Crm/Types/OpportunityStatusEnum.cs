using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<OpportunityStatusEnum>))]
public enum OpportunityStatusEnum
{
    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "WON")]
    Won,

    [EnumMember(Value = "LOST")]
    Lost,
}
