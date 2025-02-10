using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<OpportunitiesListRequestStatus>))]
public enum OpportunitiesListRequestStatus
{
    [EnumMember(Value = "LOST")]
    Lost,

    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "WON")]
    Won,
}
