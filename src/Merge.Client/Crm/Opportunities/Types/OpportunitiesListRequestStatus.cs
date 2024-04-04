using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Crm;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum OpportunitiesListRequestStatus
{
    [EnumMember(Value = "LOST")]
    Lost,

    [EnumMember(Value = "OPEN")]
    Open,

    [EnumMember(Value = "WON")]
    Won
}
