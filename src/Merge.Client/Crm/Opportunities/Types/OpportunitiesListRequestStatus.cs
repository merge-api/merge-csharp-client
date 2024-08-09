using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<OpportunitiesListRequestStatus>))]
public enum OpportunitiesListRequestStatus
{
    [EnumMember(Value = "LOST")]
    Lost,

    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "WON")]
    Won
}
