using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Crm;

[JsonConverter(typeof(EnumSerializer<DirectionEnum>))]
public enum DirectionEnum
{
    [EnumMember(Value = "INBOUND")]
    Inbound,

    [EnumMember(Value = "OUTBOUND")]
    Outbound,
}
