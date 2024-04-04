using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Crm;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum DirectionEnum
{
    [EnumMember(Value = "INBOUND")]
    Inbound,

    [EnumMember(Value = "OUTBOUND")]
    Outbound
}
