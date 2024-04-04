using System.Text.Json.Serialization;
using System;
using Merge.Client.Utilities;

namespace Merge.Client.Accounting;

[JsonConverter(typeof(TolerantEnumConverter))]
public enum Status7D1Enum
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "ARCHIVED")]
    Archived
}
