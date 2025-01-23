using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

#nullable enable

namespace Merge.Client.Accounting;

[JsonConverter(typeof(StringEnumSerializer<ComponentTypeEnum>))]
public enum ComponentTypeEnum
{
    [EnumMember(Value = "SALES")]
    Sales,

    [EnumMember(Value = "PURCHASE")]
    Purchase,
}
