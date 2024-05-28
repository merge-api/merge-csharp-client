using System.Runtime.Serialization;

#nullable enable

namespace Merge.Client.Accounting;

public enum Status7D1Enum
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "ARCHIVED")]
    Archived
}
