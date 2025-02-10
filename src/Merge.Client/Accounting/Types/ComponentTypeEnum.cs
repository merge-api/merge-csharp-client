using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<ComponentTypeEnum>))]
public enum ComponentTypeEnum
{
    [EnumMember(Value = "SALES")]
    Sales,

    [EnumMember(Value = "PURCHASE")]
    Purchase,
}
