using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<Type2BbEnum>))]
public enum Type2BbEnum
{
    [EnumMember(Value = "INVENTORY")]
    Inventory,

    [EnumMember(Value = "NON_INVENTORY")]
    NonInventory,

    [EnumMember(Value = "SERVICE")]
    Service,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,
}
