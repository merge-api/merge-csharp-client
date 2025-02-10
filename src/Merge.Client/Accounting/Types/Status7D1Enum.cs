using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Merge.Client.Core;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(EnumSerializer<Status7D1Enum>))]
public enum Status7D1Enum
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "ARCHIVED")]
    Archived,
}
