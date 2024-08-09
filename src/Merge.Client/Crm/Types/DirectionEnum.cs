using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Crm;

[JsonConverter(typeof(StringEnumSerializer<DirectionEnum>))]
public enum DirectionEnum
{
    [EnumMember(Value = "INBOUND")]
    Inbound,

    [EnumMember(Value = "OUTBOUND")]
    Outbound
}
