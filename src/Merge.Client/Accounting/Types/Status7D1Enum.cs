using System.Runtime.Serialization;

namespace Merge.Client.Accounting;

public enum Status7D1Enum
{
    [EnumMember(Value = "ACTIVE")]
    Active,

    [EnumMember(Value = "ARCHIVED")]
    Archived
}
